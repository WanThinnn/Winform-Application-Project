using BCrypt.Net;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Google.Apis.Oauth2.v2;
using Google.Apis.Services;
using Google.Apis.Oauth2.v2.Data;
namespace UI
{
    public partial class Login : Form
    {
        static string[] Scopes = { Oauth2Service.Scope.UserinfoEmail, Oauth2Service.Scope.UserinfoProfile };
        static string ApplicationName = "Neko";
        public Login()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txUser.Text) ||
               string.IsNullOrWhiteSpace(txPass.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FirebaseResponse res = client.Get(@"Users/" + txUser.Text);
            NekoUser ResUser = res.ResultAs<NekoUser>();
            string HashPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(txPass.Text, hashType: HashType.SHA384);


            NekoUser CurUser = new NekoUser()
            {
                Username = txUser.Text,
                Password = txPass.Text,
            };

            if (NekoUser.IsEqual(ResUser, CurUser) == true)
            {
                if (ResUser.Position == "Master" || ResUser.Position == "Admin")
                {
      
                    AdminFP admin = new AdminFP(ResUser.Master);
                    this.Hide();
                    admin.ShowDialog();
                    this.Show();
                }
                else 
                {
                    User user = new User();
                    this.Hide();
                    user.ShowDialog();
                    this.Show();
                }



            }
            else
            {
                NekoUser.ShowError();
            }
        }

        private void Login_Load(object sender, EventArgs e)
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


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            BeforSignUp reg = new BeforSignUp();
            this.Hide();
            reg.ShowDialog();
            this.ShowDialog();
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

        private void lkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPwd res = new ForgotPwd();
            this.Hide();
            res.ShowDialog();
            this.ShowDialog();
        }




        private async Task<bool> GoogleLogin()
        {
            UserCredential credential;
            var clientSecrets = new ClientSecrets
            {
                ClientId = "38250210888-tcoufrdv7qpni08rll8710nqvqvupnv3.apps.googleusercontent.com",
                ClientSecret = "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"
            };

            // Đường dẫn tới thư mục AppData
            string credPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NekoGoogleLogin");

            try
            {
                // Tạo thư mục nếu không tồn tại
                Directory.CreateDirectory(credPath);

                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    clientSecrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true));

                // Xác định đường dẫn file token mặc định
                string tokenFilePath = Path.Combine(credPath, "Google.Apis.Auth.OAuth2.Responses.TokenResponse-user");

                // Kiểm tra nếu token đã được lưu thành công
                if (File.Exists(tokenFilePath))
                {
                    //MessageBox.Show($"Token saved successfully at: {tokenFilePath}");
                }
                else
                {
                    //MessageBox.Show("Token save failed.");
                    return false;
                }

                // Đăng nhập thành công, lấy thông tin người dùng
                var service = new Oauth2Service(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                var userInfo = service.Userinfo.Get().Execute();


                // Kiểm tra xem người dùng đã tồn tại trong Firebase chưa
                FirebaseResponse response = await client.GetAsync("Users/" + userInfo.Id);
                NekoUser existingUser = response.ResultAs<NekoUser>();

                if (existingUser == null)
                {
                    // Người dùng chưa tồn tại, lưu thông tin vào Firebase
                    NekoUser user = new NekoUser()
                    {
                        Username = userInfo.Id,
                        Fullname = userInfo.Name,
                        Email = userInfo.Email,
                        Gender = userInfo.Gender, // Lưu ý: Giới tính có thể không được trả về bởi Google API
                        Position = "Google User"
                    };

                    SetResponse set = await client.SetAsync("Users/" + userInfo.Id, user);
                    if (set.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        return true;
                    }
                    else
                    {
                        //MessageBox.Show("Failed to save user info to database.");
                        return false;
                    }
                }
                else
                {
                    // Người dùng đã tồn tại
                    //MessageBox.Show("User already exists in the database.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi trong quá trình đăng nhập: {ex.Message}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        private void LogoutGoogle()
        {
            string credPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NekoGoogleLogin");
            string tokenFilePath = Path.Combine(credPath, "Google.Apis.Auth.OAuth2.Responses.TokenResponse-user");

            if (File.Exists(tokenFilePath))
            {
                try
                {
                    File.Delete(tokenFilePath); // Xóa file token chính xác
                    //MessageBox.Show($"Token file deleted from: {tokenFilePath}");
                    //MessageBox.Show("See you again!"); // Thông báo đăng xuất thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi trong quá trình đăng xuất: {ex.Message}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //MessageBox.Show("No login session found."); // Thông báo nếu file không tồn tại
                return;
            }
        }
        private async void btnLoginGoogle_Click(object sender, EventArgs e)
        {
            bool loginSuccess = await GoogleLogin();
            if (loginSuccess)
            {

                FirebaseResponse res = client.Get(@"Users/" + txUser.Text);

                NekoUser ResUser = res.ResultAs<NekoUser>();
                if (ResUser == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                if (ResUser.Position != "Master" || ResUser.Position != "Admin")
                {
                    User user = new User();
                    this.Hide();
                    user.ShowDialog();
                    this.Show();
                }


            }
            else
            {
                MessageBox.Show($"Đã xảy ra lỗi trong quá trình đăng nhập, vui lòng thử lại sau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogoutGoogle();
        }
    }
}
