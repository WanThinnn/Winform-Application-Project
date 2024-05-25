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
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using FireSharp.Response;
using System.Text.RegularExpressions;
using Aspose.Email.Clients.Graph;

namespace UI
{
    public partial class ForgotPwd : Form
    {
    
        public ForgotPwd()
        {
            InitializeComponent();

        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
   
        private void SendEmail(string recipientEmail, VerificationCodeInfo verificationCode)
        {
            try
            {
                var email = new MimeMessage();

                email.From.Add(new MailboxAddress("Neko Coffee", "nekocoffe.app@gmail.com"));
                email.To.Add(new MailboxAddress("Client", recipientEmail));

                email.Subject = "[Neko Coffee] - Quên mật khẩu";

                // Tạo nội dung email dạng HTML
                var bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = $@"
<p style=""color: black;"">Xin chào,</p>
<p style=""color: black;"">Chúng tôi nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn trên Neko Coffe App. Để hoàn tất quá trình này, vui lòng làm nhập mã xác thực sau:</p>
<p style=""color: black;"">Mã xác thực của bạn là: <b>{verificationCode.Code}</b></p>
<p style=""color: black;"">Nếu bạn cần thêm sự trợ giúp hoặc có bất kỳ câu hỏi nào, vui lòng liên hệ với chúng tôi qua email này.<br> <br>
Trân trọng,<br>
Neko Coffe Team.</p>";

                // Gán nội dung email vào email object
                email.Body = bodyBuilder.ToMessageBody();

                // Sử dụng MailKit để gửi email
                using (var smtp = new MailKit.Net.Smtp.SmtpClient())
                {
                    smtp.Connect("smtp.gmail.com", 587, false);

                    // Xác thực với tên người dùng và mật khẩu của tài khoản Gmail
                    smtp.Authenticate("nekocoffe.app@gmail.com", "tffa kqbg luyj nlqy");

                    // Gửi email
                    smtp.Send(email);

                    // Ngắt kết nối sau khi gửi xong
                    smtp.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }

        }
        private void ForgotPwd_Load(object sender, EventArgs e)
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
        public bool IsValidEmail(string email)
        {
            email = email.ToLower();
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Kiểm tra định dạng email
                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return regex.IsMatch(email);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        private void txtSendCode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
            string.IsNullOrWhiteSpace(txtUserName.Text) ||
               string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string emailToCheck = txtEmail.Text;
            // Kiểm tra tính hợp lệ của email
            if (!IsValidEmail(emailToCheck))
            {
                MessageBox.Show("Email không hợp lệ!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            FirebaseResponse res = client.Get(@"Users/" + txtUserName.Text);
           
            NekoUser ResUser = res.ResultAs<NekoUser>();
            if (ResUser == null)
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (ResUser.Position == "Master")
            {
                MessageBox.Show("Vì lý do bảo mật, vui lòng đổi mật khẩu tại ứng dụng Master Neko Coffee", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            NekoUser CurUser = new NekoUser()
            {
                Username = txtUserName.Text,
                Email = txtEmail.Text.ToLower(),
                PhoneNumber = txtPhone.Text
            };

            if (NekoUser.IsExist(ResUser, CurUser) == true)
            {
                string recipientEmail = txtEmail.Text.ToLower(); // Địa chỉ email của người nhận
                                                       // Deserialize the response to NekoUser object
             

                VerificationCodeInfo verificationInfo = VerificationCodeInfo.GenerateVerificationCode();
                ChangePwd changepwd = new ChangePwd(verificationInfo, txtUserName.Text);



                // Gửi mã code đến email của người nhận
                SendEmail(recipientEmail, verificationInfo);
                MessageBox.Show("Vui lòng kiểm tra hộp thư", "Lưu ý!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                changepwd.ShowDialog();
                this.Show();

            }
            else
            {
                NekoUser.ShowError();
            }
        }

        private void lbDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
