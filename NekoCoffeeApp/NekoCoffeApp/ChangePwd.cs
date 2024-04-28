using BCrypt.Net;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ChangePwd : Form
    {
        VerificationCodeInfo VerificationCode;
        string Username;
        public ChangePwd(VerificationCodeInfo verificationCode, string username)
        {
            InitializeComponent();
            this.VerificationCode = verificationCode; // Gán giá trị của thuộc tính Code
            this.Username = username;
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        private void ChangePwd_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txbNewPwd_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txbNewPwd.Text))
            {
                this.txbNewPwd.PlaceholderText = "Password";
                this.txbNewPwd.PasswordChar = '\0'; // Loại bỏ ký tự password
            }
            else
            {
                this.txbNewPwd.PlaceholderText = "";
                this.txbNewPwd.PasswordChar = '●';
            }
        }

        private void txbCfNewPwd_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txbCfNewPwd.Text))
            {
                this.txbCfNewPwd.PlaceholderText = "Password";
                this.txbCfNewPwd.PasswordChar = '\0'; // Loại bỏ ký tự password
            }
            else
            {
                this.txbCfNewPwd.PlaceholderText = "";
                this.txbCfNewPwd.PasswordChar = '●';
            }
        }


        private void txtChangePass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbNewPwd.Text) ||
                string.IsNullOrWhiteSpace(txbCfNewPwd.Text) ||
                string.IsNullOrWhiteSpace(txbCode.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DateTime.Now - VerificationCode.CreatedAt > TimeSpan.FromSeconds(360))

            {
                // Mã xác nhận đã hết hạn
                MessageBox.Show("Mã xác nhận không đúng hoặc hết hạn!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem VerificationCode có null không
            if (VerificationCode == null)
            {
                MessageBox.Show("Mã xác nhận không hợp lệ!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mã xác nhận vẫn còn hiệu lực
            if (this.VerificationCode.Code == txbCode.Text)
            {
                var res = client.Get("Users/" + Username);
                NekoUser userOld = res.ResultAs<NekoUser>();
                NekoUser user = new NekoUser()
                {
                    Username = userOld.Username,
                    Password = BCrypt.Net.BCrypt.EnhancedHashPassword(txbNewPwd.Text, hashType: HashType.SHA384),
                    Fullname = userOld.Fullname,
                    Gender = userOld.Gender,
                    PhoneNumber = userOld.PhoneNumber,
                    Email = userOld.Email,
                    Position = userOld.Position
                };
                var up = client.Update(@"Users/" + Username, user);
                if (up.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"Đổi mật khẩu thành công tài khoản {Username}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Mã xác nhận không đúng hoặc hết hạn!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
