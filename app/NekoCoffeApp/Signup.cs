using BCrypt.Net;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Email;
namespace UI
{
    public partial class Signup : Form
    {
        string newEmail;
        VerificationCodeInfo VerificationCode;

        public Signup(VerificationCodeInfo verificationCode, string email)
        {
            InitializeComponent();
            this.VerificationCode = verificationCode;
            this.newEmail = email;
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        private void Signup_Load(object sender, EventArgs e)
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

        bool ValidateEmail(string email)
        {
            // Xác thực định dạng và cú pháp
            bool isValidFormat = System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!isValidFormat) return false;

    

            return true;
        }


        private void txtSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
               string.IsNullOrWhiteSpace(txtPhone.Text) ||
               string.IsNullOrWhiteSpace(txPass.Text) ||
               string.IsNullOrWhiteSpace(txtConfirm.Text) ||
               string.IsNullOrWhiteSpace(txtCode.Text) ||
               string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txPass.Text != txtConfirm.Text)

            {
                MessageBox.Show("Mật khẩu không khớp!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = client.Get(@"Users/" + txtUserName.Text);
            NekoUser ResUser = res.ResultAs<NekoUser>();

            NekoUser CurUser = new NekoUser()
            {
                Username = txtUserName.Text
            };

            if (NekoUser.Search(ResUser, CurUser))
            {
                NekoUser.ShowError_2();
                return;
            }

            if (txtCode.Text != VerificationCode.Code)
            {
                MessageBox.Show("Mã xác nhận không đúng hoặc hết hạn!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NekoUser user = new NekoUser()
            {
                Username = txtUserName.Text,
                Password = BCrypt.Net.BCrypt.EnhancedHashPassword(txPass.Text, hashType: HashType.SHA384),
                Fullname = txtFullName.Text,
                Gender = dbGender.Text,
                PhoneNumber = txtPhone.Text,
                Email = newEmail,
                Position = "KH"
            };

            SetResponse set = client.Set(@"Users/" + txtUserName.Text, user);

            if (set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Đăng ký thành công tài khoản {txtUserName.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txPass_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txPass.Text))
            {
                this.txPass.PlaceholderText = "Password";
                this.txPass.PasswordChar = '\0'; // Loại bỏ ký tự password
            }
            else
            {
                this.txPass.PlaceholderText = "";
                this.txPass.PasswordChar = '●';
            }
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtConfirm.Text))
            {
                this.txtConfirm.PlaceholderText = "Password";
                this.txtConfirm.PasswordChar = '\0'; // Loại bỏ ký tự password
            }
            else
            {
                this.txtConfirm.PlaceholderText = "";
                this.txtConfirm.PasswordChar = '●';
            }
        }
    }
}
