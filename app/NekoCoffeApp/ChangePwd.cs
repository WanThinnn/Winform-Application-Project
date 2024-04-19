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

namespace UI
{
    public partial class ChangePwd : Form
    {
        string VerificationCode;
        string Username;
        public ChangePwd(string verificationCode, string username)
        {
            InitializeComponent();
            this.VerificationCode = verificationCode;
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
            if (string.IsNullOrWhiteSpace(txbNewPwd.Text) &&
                 string.IsNullOrWhiteSpace(txbCfNewPwd.Text) &&
                 string.IsNullOrWhiteSpace(txbCode.Text) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.VerificationCode == txbCode.Text)
            {
                
                NekoUser user = new NekoUser()
                {
                    Password = BCrypt.Net.BCrypt.EnhancedHashPassword(txbNewPwd.Text, hashType: HashType.SHA384)

                };

       

                var update = client.Update(@"Users/" + Username, user);

                if (update.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //txbUsrname.Clear();
                    //txbPass.Clear();
                    //cbGender.SelectedIndex = -1;
                    //txbFullname.Clear();
                    //txbPhone.Clear();

                }

            }
            else
            {
                MessageBox.Show("Code không đúng hoặc hết hạn!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
