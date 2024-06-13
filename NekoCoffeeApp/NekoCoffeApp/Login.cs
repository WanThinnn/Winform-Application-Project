using BCrypt.Net;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Google.Apis.Oauth2.v2;
using Google.Apis.Services;
using Google.Apis.Oauth2.v2.Data;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace UI
{
    public partial class Login : Form
    {
        static string[] Scopes = { Oauth2Service.Scope.UserinfoEmail, Oauth2Service.Scope.UserinfoProfile };
        static string ApplicationName = "Neko";

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txUser.Text) || string.IsNullOrWhiteSpace(txPass.Text))
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
                GlobalVars.CurrentUser = ResUser;

                if (ResUser.Position == "Master" || ResUser.Position == "Admin")
                {
                    AdminFP admin = new AdminFP();
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
            this.Show();
        }

        private void txPass_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txPass.Text))
            {
                this.txPass.PlaceholderText = "Password";
                this.txPass.PasswordChar = '\0';
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

            string credPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NekoGoogleLogin");

            try
            {
                Directory.CreateDirectory(credPath);

                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    clientSecrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true));

                string tokenFilePath = Path.Combine(credPath, "Google.Apis.Auth.OAuth2.Responses.TokenResponse-user");

                if (!File.Exists(tokenFilePath))
                {
                    return false;
                }

                var userInfo = await GetUserInfo(credential.Token.AccessToken);
                var avatarUrl = await GetAvatarUrl(credential.Token.AccessToken);
                var birthday = await GetUserBirthday(credential.Token.AccessToken);

                FirebaseResponse response = await client.GetAsync("Users/" + userInfo["sub"].ToString());
                NekoUser existingUser = response.ResultAs<NekoUser>();

                if (existingUser == null)
                {
                    NekoUser user = new NekoUser()
                    {
                        Username = userInfo["sub"].ToString(),
                        Fullname = userInfo["name"]?.ToString(),
                        Email = userInfo["email"]?.ToString(),
                        Gender = userInfo["gender"]?.ToString(),
                        Position = "Google User",
                        Point = 0,
                        hasBooking = "false",
                        Avatar = avatarUrl,
                        Birthday = birthday,
                        RegistrationDate = DateTime.Now,
                    };

                    SetResponse set = await client.SetAsync("Users/" + userInfo["sub"].ToString(), user);
                    if (set.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        GlobalVars.CurrentUser = user;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    GlobalVars.CurrentUser = existingUser;
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi trong quá trình đăng nhập: {ex.Message}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private async Task<JObject> GetUserInfo(string accessToken)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                var response = await client.GetAsync("https://www.googleapis.com/oauth2/v3/userinfo");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JObject.Parse(json);
                }
                else
                {
                    throw new Exception("Unable to retrieve user info");
                }
            }
        }

        private async Task<string> GetAvatarUrl(string accessToken)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                var response = await client.GetAsync("https://www.googleapis.com/oauth2/v3/userinfo");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var userInfo = JObject.Parse(json);
                    var pictureUrl = userInfo["picture"]?.ToString();

                    if (!string.IsNullOrEmpty(pictureUrl))
                    {
                        if (pictureUrl.Contains("=s"))
                        {
                            pictureUrl = Regex.Replace(pictureUrl, @"=s\d+", "=s200");
                        }
                        else
                        {
                            pictureUrl += "?sz=300"; // Tăng kích thước ảnh lên 300x300
                        }
                    }

                    return pictureUrl;
                }
                else
                {
                    throw new Exception("Unable to retrieve user info");
                }
            }
        }

        private async Task<string> GetUserBirthday(string accessToken)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                var response = await client.GetAsync("https://people.googleapis.com/v1/people/me?personFields=birthdays");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var userInfo = JObject.Parse(json);
                    var birthdays = userInfo["birthdays"];
                    if (birthdays != null && birthdays.HasValues)
                    {
                        var birthday = birthdays[0]["date"];
                        return $"{birthday["year"]}-{birthday["month"]}-{birthday["day"]}";
                    }
                }
            }

            return null;
        }

        private void LogoutGoogle()
        {
            string credPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NekoGoogleLogin");
            string tokenFilePath = Path.Combine(credPath, "Google.Apis.Auth.OAuth2.Responses.TokenResponse-user");

            if (File.Exists(tokenFilePath))
            {
                try
                {
                    File.Delete(tokenFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi trong quá trình đăng xuất: {ex.Message}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private async void btnLoginGoogle_Click(object sender, EventArgs e)
        {
            bool loginSuccess = await GoogleLogin();
            if (loginSuccess)
            {
                if (GlobalVars.CurrentUser != null)
                {
                    if (GlobalVars.CurrentUser.Position != "Master" && GlobalVars.CurrentUser.Position != "Admin")
                    {
                        User user = new User();
                        this.Hide();
                        user.ShowDialog();
                        this.Show();
                    }
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
