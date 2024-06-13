using BCrypt.Net;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Google.Apis.PeopleService.v1.Data;
using MimeKit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class UserGetItem : Form
    {
        NekoItem Item;
        public UserGetItem(NekoItem item)
        {
            InitializeComponent();
            this.Item = item;
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void Customer_Load(object sender, EventArgs e)
        {

            

        }
        
        public bool IsValidEmail(string email)
        {
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
        
       

        
        private async void UserUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbUsername.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            FirebaseResponse res = await client.GetAsync("Users/" + txbUsername.Text);
            if (res.Body == "null")
            {
                MessageBox.Show("Người dùng không tồn tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NekoUser user = res.ResultAs<NekoUser>();

   

            var updateData = new NekoUser
            {
                Username = user.Username,
                Password = user.Password,
                Fullname = user.Fullname,
                Gender = user.Gender,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                Position = user.Position,
                RegistrationDate = user.RegistrationDate,
                Point = user.Point - int.Parse(Item.Point),
                Birthday = user.Birthday,
                Master = user.Master,
                hasBooking = user.hasBooking,
                Avatar = user.Avatar,

            };

            SetResponse up = await client.SetAsync("Users/" + user.Username, updateData);
            if (up.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Sửa thông tin thành công tài khoản {user.Username}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            btnRefresh_Click(sender, e);

        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
          
          
            txbUsername.Clear();
           tbPhone.Clear();
            tbFullname.Clear();
            tbEmail.Clear();
          
            tbPhone.Clear();
          
           


     
    
        }
        private void SendEmail(string recipientEmail, NekoItem item)
        {
            if 
                (string.IsNullOrWhiteSpace(txbUsername.Text) || string.IsNullOrWhiteSpace(tbEmail.Text) ||  string.IsNullOrWhiteSpace(tbPhone.Text) || string.IsNullOrWhiteSpace(tbFullname.Text))
                
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                var email = new MimeMessage();

                email.From.Add(new MailboxAddress("Neko Coffee", "nekocoffe.app@gmail.com"));
                email.To.Add(new MailboxAddress("Client", recipientEmail));

                email.Subject = "[Neko Coffee] - Đổi Điểm Nhận Quà";
                FirebaseResponse res =  client.Get("Users/" + txbUsername.Text);
                if (res.Body == "null")
                {
                    MessageBox.Show("Người dùng không tồn tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                NekoUser user = res.ResultAs<NekoUser>();
                // Tạo nội dung email dạng HTML
                var bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = $@"
<p style=""color: black;"">Xin chào,</p>
<p style=""color: black;"">Chúng tôi nhận được yêu cầu đổi quà từ bạn cho email này trên Neko Coffe App, với thông tin như sau: </b></p>
<p style=""color: black;"">Mã số: {item.ID} - Tên sản phẩm: {item.Name} - Điểm: {Item.Point}. <br>Quà sẽ được vận chuyển từ 1 đến 4 ngày tuỳ theo vị trí địa lý và dịch vụ<br> 
<p style=""color: black;"">Số điểm còn lại của bạn là: {user.Point - int.Parse(this.Item.Point)}.Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi!. <br><br>
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
                MessageBox.Show("Vui lòng kiểm tra hộp thư", "Lưu ý!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }

        }
        private void btnSendMail_Click(object sender, EventArgs e)
        {
            // Hiển thị MessageBox để xác nhận việc gửi email
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn nhận sản phẩm?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Nếu người dùng chọn OK, thực hiện gửi email
            if (result == DialogResult.OK)
            {
                SendEmail(tbEmail.Text, this.Item);
                UserUpdate_Click(sender, e);


            }
            btnRefresh_Click(sender, e);
        }

        private void UserGetItem_Load(object sender, EventArgs e)
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
