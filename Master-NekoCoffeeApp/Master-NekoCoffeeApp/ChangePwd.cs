using BCrypt.Net;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_NekoCoffeeApp
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
        private async void txtChangePass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbNewPwd.Text) ||
                string.IsNullOrWhiteSpace(txbCfNewPwd.Text) ||
                string.IsNullOrWhiteSpace(txbCode.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txbNewPwd.Text != txbCfNewPwd.Text)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không khớp!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (VerificationCode == null)
            {
                MessageBox.Show("Mã xác nhận không hợp lệ!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DateTime.Now - VerificationCode.CreatedAt > TimeSpan.FromSeconds(360))
            {
                MessageBox.Show("Mã xác nhận không đúng hoặc hết hạn!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.VerificationCode.Code == txbCode.Text)
            {
                try
                {
                    var res = await client.GetAsync("MasterUsers/" + Username);
                    if (res.Body == "null")
                    {
                        MessageBox.Show("Người dùng không tồn tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(txbNewPwd.Text, hashType: HashType.SHA384);
                    var updateData = new Dictionary<string, object>
                    {
                        { "Password", hashedPassword }
                    };

                    var up = await client.UpdateAsync("MasterUsers/" + Username, updateData);
                    if (up.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show($"Đổi mật khẩu thành công tài khoản {Username}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mã xác nhận không đúng hoặc hết hạn!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                this.txbNewPwd.PlaceholderText = "Password";
                this.txbNewPwd.PasswordChar = '\0'; // Loại bỏ ký tự password
            }
            else
            {
                this.txbNewPwd.PlaceholderText = "";
                this.txbNewPwd.PasswordChar = '●';
            }
        }
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
    }
}
