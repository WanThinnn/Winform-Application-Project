using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using MimeKit;
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
    public partial class BeforSignUp : Form
    {
        public BeforSignUp()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        //static string GenerateVerificationCode()
        //{
        //    // Tạo một đối tượng Random để tạo mã ngẫu nhiên
        //    Random random = new Random();

        //    // Tạo mã code gồm 6 số ngẫu nhiên
        //    int code = random.Next(100000, 999999);

        //    return code.ToString();
        //}

        static VerificationCodeInfo GenerateVerificationCode()
        {
            Random random = new Random();
            int code = random.Next(100000, 999999);
            DateTime createdAt = DateTime.Now;
            return new VerificationCodeInfo { Code = code.ToString(), CreatedAt = createdAt };
        }
        private void SendEmail(string recipientEmail, VerificationCodeInfo verificationCode)
        {
            try
            {
                var email = new MimeMessage();

                email.From.Add(new MailboxAddress("Neko Coffe", "nekocoffe.app@gmail.com"));
                email.To.Add(new MailboxAddress("Client", recipientEmail));

                email.Subject = "[Neko Coffe] - Đăng ký thành viên";

                // Tạo nội dung email dạng HTML
                var bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = $@"
<p style=""color: black;"">Xin chào,</p>
<p style=""color: black;"">Chúng tôi nhận được yêu cầu tạo tài khoản mới cho email này của bạn trên Neko Coffe App. Để hoàn tất quá trình này, vui lòng làm nhập mã xác thực sau:</p>
<p style=""color: black;"">Mã xác thực của bạn là: <b>{verificationCode.Code}</b></p>
<p style=""color: black;"">Nếu bạn không yêu cầu tạo tài khoản hoặc không nhớ đến yêu cầu này, vui lòng bỏ qua email này. <br> 
Nếu bạn cần thêm sự trợ giúp hoặc có bất kỳ câu hỏi nào, vui lòng liên hệ với chúng tôi qua email này. <br>
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
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbEmail.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            string recipientEmail = txbEmail.Text; // Địa chỉ email của người nhận

            VerificationCodeInfo verificationInfo = VerificationCodeInfo.GenerateVerificationCode();
            Signup sigbup = new Signup(verificationInfo, txbEmail.Text);



            // Gửi mã code đến email của người nhận
            SendEmail(recipientEmail, verificationInfo);
            MessageBox.Show("Vui lòng kiểm tra hộp thư", "Lưu ý!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            sigbup.ShowDialog();
            this.ShowDialog();

        }

        private void BeforSignUp_Load(object sender, EventArgs e)
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

        private void lkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login res = new Login();
            this.Hide();
            res.ShowDialog();
            this.ShowDialog();
        }
    }
}
