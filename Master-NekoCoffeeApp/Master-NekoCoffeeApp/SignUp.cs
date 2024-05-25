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

namespace Master_NekoCoffeeApp
{
    public partial class SignUp : Form
    {
        public SignUp(VerificationCodeInfo verificationCode, string email)
        {
            InitializeComponent();
            this.VerificationCode = verificationCode;
            this.Email = email;
        }
        string Email;
        VerificationCodeInfo VerificationCode;
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        bool ValidateEmail(string email)
        {
            // Xác thực định dạng và cú pháp
            bool isValidFormat = System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!isValidFormat) return false;



            return true;
        }

        private async void txtSignUp_Click(object sender, EventArgs e)
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

            FirebaseResponse res = await client.GetAsync("MasterUsers/" + txtUserName.Text);
            FirebaseResponse nekores = await client.GetAsync("Users/" + txtUserName.Text);
            MasterUser ResUser = res.ResultAs<MasterUser>();
            NekoUser NekoResUser = nekores.ResultAs<NekoUser>();

            MasterUser CurUser = new MasterUser()
            {
                Username = txtUserName.Text
            };

            NekoUser NekoCurUser = new NekoUser()
            {
                Username = txtUserName.Text
            };

            // Nếu ResUser không phải là null, thực hiện kiểm tra
            if ((ResUser != null && MasterUser.Search(ResUser, CurUser)) || NekoResUser != null && NekoUser.Search(NekoResUser, NekoCurUser))
            {
                MasterUser.ShowError_2();
                return;
            }

            if (DateTime.Now - VerificationCode.CreatedAt > TimeSpan.FromSeconds(360))
            {
                // Mã xác nhận đã hết hạn
                MessageBox.Show("Mã xác nhận không đúng hoặc hết hạn!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCode.Text != VerificationCode.Code)
            {
                MessageBox.Show("Mã xác nhận không đúng hoặc hết hạn!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MasterUser user = new MasterUser()
            {
                Username = txtUserName.Text,
                Password = BCrypt.Net.BCrypt.EnhancedHashPassword(txPass.Text, hashType: HashType.SHA384),
                Fullname = txtFullName.Text,
                Gender = dbGender.Text,
                PhoneNumber = txtPhone.Text,
                Email = Email.ToLower(),
                Position = "Master",
                RegistrationDate = DateTime.Now // Gán ngày đăng ký tại đây
            };

            SetResponse set = await client.SetAsync("Users/" + txtUserName.Text, user);
            SetResponse set_2 = await client.SetAsync("MasterUsers/" + txtUserName.Text, user);

            if (set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Đăng ký thành công tài khoản {txtUserName.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formLogin loginForm = new formLogin();
                this.Close(); // Đóng form SignUp
            }
            else
            {
                MessageBox.Show($"Đăng ký không thành công tài khoản!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void SignUp_Load(object sender, EventArgs e)
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

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
