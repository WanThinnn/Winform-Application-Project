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
using Firebase.Storage;
namespace UI
{
    public partial class Signup : Form
    {
        string Email;
        VerificationCodeInfo VerificationCode;

        string selectedImagePath; // Add this property

        public Signup(VerificationCodeInfo verificationCode, string email)
        {
            InitializeComponent();
            this.VerificationCode = verificationCode;
            this.Email = email;
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        FirebaseStorage firebaseStorage;

        IFirebaseClient client;
        private void Signup_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
                firebaseStorage = new FirebaseStorage("neko-coffe-database.appspot.com");
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

            string avatarUrl = null;
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                var stream = System.IO.File.Open(selectedImagePath, System.IO.FileMode.Open);
                var task = new FirebaseStorage("neko-coffe-database.appspot.com")
                    .Child("avatars")
                    .Child(txtUserName.Text + System.IO.Path.GetExtension(selectedImagePath))
                    .PutAsync(stream);

                try
                {
                    avatarUrl = await task;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải ảnh lên Firebase Storage: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            NekoUser user = new NekoUser()
            {
                Username = txtUserName.Text,
                Password = BCrypt.Net.BCrypt.EnhancedHashPassword(txPass.Text, hashType: HashType.SHA384),
                Fullname = txtFullName.Text,
                Gender = dbGender.Text,
                PhoneNumber = txtPhone.Text,
                Email = Email.ToLower(),
                Position = "KH",
                RegistrationDate = DateTime.Now, // Gán ngày đăng ký tại đây
                Point = 0,
                Birthday = txbBirthday.Text,
                Master = "",
                Avatar = avatarUrl // Save the avatar URL
            };

            SetResponse set = client.Set(@"Users/" + txtUserName.Text, user);

            if (set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Đăng ký thành công tài khoản {txtUserName.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login loginForm = new Login();
                this.Close(); // Đóng form SignUp
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

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image File(*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = ofd.FileName; // Save the selected image path
                // Optionally, show the selected image in a PictureBox or similar control
                // pictureBoxAvatar.Image = Image.FromFile(selectedImagePath);
            }
        }
    }
}
