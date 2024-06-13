using BCrypt.Net;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class GetItems : Form
    {
        NekoItem Item;
        public GetItems(NekoItem item)
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

            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            viewData();
            btnSendMail.Enabled = false;

        }
        void viewData()
        {
            try
            {
                var data = client.Get(@"/Users/");

                // Check if data or data.Body is null
                if (data == null || data.Body == null)
                {
                    // Optionally, handle the null case here
                    UserView.DataSource = null;
                    return;
                }

                var mList = JsonConvert.DeserializeObject<IDictionary<string, NekoUser>>(data.Body);

                // Check if mList is null or empty
                if (mList == null || !mList.Any())
                {
                    // Optionally, handle the empty case here
                    UserView.DataSource = null;
                    return;
                }

                // Filter the list to only include users of type "KH", "KHTT", "KHVIP"
                var filteredList = mList.Values
                    .Where(user => user.Position == "KH" || user.Position == "KHTT" || user.Position == "KHVIP" || user.Position == "Google User")
                    .ToList();

                // Check if filteredList is empty
                if (!filteredList.Any())
                {
                    UserView.DataSource = null;
                    return;
                }

                UserView.DataSource = filteredList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void UserCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageBox.Show("Vui lòng điền tên tài khoản", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = client.Get(@"Users/" + tbUsername.Text);
            NekoUser user = res.ResultAs<NekoUser>();

            if (user == null)
            {
                MessageBox.Show("Tài không không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dbGender.ForeColor = Color.Black;
            tbPwd.ReadOnly = true;
            txbUsername.ReadOnly = true;
            txbUsername.Text = user.Username;

            tbPwd.BorderColorActive = Color.Silver;
            tbPwd.BorderColorHover = Color.Silver;
            tbPwd.BorderColorDisabled = Color.Silver;
            tbPwd.BorderColorIdle = Color.Silver;

            txbUsername.BorderColorActive = Color.Silver;
            txbUsername.BorderColorHover = Color.Silver;
            txbUsername.BorderColorDisabled = Color.Silver;
            txbUsername.BorderColorIdle = Color.Silver;

            tbPwd.Text = user.Password;
            tbFullname.Text = user.Fullname;
            tbEmail.Text = user.Email;
            tbPoint.Text = user.Point.ToString();
            tbType.Text = user.Position;
            tbPhone.Text = user.PhoneNumber;
            tbDate.Text = user.RegistrationDate.ToString();
            dbGender.Text = user.Gender;
            txbBirthday.Text = user.Birthday;


            btnSendMail.Enabled = true;
        }

        private async void UserAdd_Click(object sender, EventArgs e)
        {
            if (
               string.IsNullOrWhiteSpace(txbUsername.Text) ||
               string.IsNullOrWhiteSpace(tbPwd.Text) ||
               string.IsNullOrWhiteSpace(tbEmail.Text) ||
               string.IsNullOrWhiteSpace(tbPhone.Text) ||
               string.IsNullOrWhiteSpace(dbGender.Text) ||
               string.IsNullOrWhiteSpace(txbBirthday.Text) ||
               string.IsNullOrWhiteSpace(tbFullname.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn thêm tài khoản này không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    FirebaseResponse res = await client.GetAsync("MasterUsers/" + txbUsername.Text);
                    FirebaseResponse nekores = await client.GetAsync("Users/" + txbUsername.Text);
                    MasterUser ResUser = res.ResultAs<MasterUser>();
                    NekoUser NekoResUser = nekores.ResultAs<NekoUser>();

                    MasterUser CurUser = new MasterUser()
                    {
                        Username = txbUsername.Text
                    };

                    NekoUser NekoCurUser = new NekoUser()
                    {
                        Username = txbUsername.Text
                    };

                    // Nếu ResUser không phải là null, thực hiện kiểm tra
                    if ((ResUser != null && MasterUser.Search(ResUser, CurUser)) || (NekoResUser != null && NekoUser.Search(NekoResUser, NekoCurUser)))
                    {
                        NekoUser.ShowError_2();
                        return;
                    }

                    // Kiểm tra tính hợp lệ của email
                    if (!IsValidEmail(tbEmail.Text.ToLower()))
                    {
                        MessageBox.Show("Email không hợp lệ!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    NekoUser user = new NekoUser()
                    {
                        Username = txbUsername.Text,
                        Password = BCrypt.Net.BCrypt.EnhancedHashPassword(tbPwd.Text, hashType: HashType.SHA384),
                        Fullname = tbFullname.Text,
                        Gender = dbGender.Text,
                        PhoneNumber = tbPhone.Text,
                        Email = tbEmail.Text.ToLower(),
                        Position = "KH",
                        RegistrationDate = DateTime.Now, // Gán ngày đăng ký tại đây
                        Point = 0,
                        Birthday = txbBirthday.Text
                    };

                    SetResponse set = await client.SetAsync("Users/" + txbUsername.Text, user);

                    if (set.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show($"Thêm thành công tài khoản {txbUsername.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Thêm không thành công tài khoản!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    btnRefresh_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void UserDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    FirebaseResponse res = await client.GetAsync("Users/" + tbUsername.Text);
                    if (res.Body == "null")
                    {
                        MessageBox.Show("Người dùng không tồn tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    NekoUser user = res.ResultAs<NekoUser>();

                    if (user.Position == "Master")
                    {
                        MessageBox.Show("Bạn không được phép xóa tài khoản Master", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    FirebaseResponse del = await client.DeleteAsync("Users/" + tbUsername.Text);
                    if (del.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show($"Xóa thông tin tài khoản {tbUsername.Text} thành công!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin thất bại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Làm mới dữ liệu sau khi xóa
                btnRefresh_Click(sender, e);
            }
        }

        private async void UserUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            FirebaseResponse res = await client.GetAsync("Users/" + tbUsername.Text);
            if (res.Body == "null")
            {
                MessageBox.Show("Người dùng không tồn tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NekoUser user = res.ResultAs<NekoUser>();

            if (user.Position == "Master")
            {
                MessageBox.Show("Bạn không được phép đổi thông tin tài khoản Master khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
            tbPwd.ReadOnly = txbUsername.ReadOnly = false;
            tbUsername.Clear();
            txbUsername.Clear();
            tbPwd.Clear();
            tbFullname.Clear();
            tbEmail.Clear();
            tbPoint.Clear();
            tbType.Clear();
            tbPhone.Clear();
            tbDate.Clear();
            txbBirthday.Clear();

            dbGender.Text = string.Empty; // Đặt giá trị hiển thị về rỗng

            tbPwd.BorderColorActive = Color.DodgerBlue;
            tbPwd.BorderColorHover = Color.FromArgb(105, 181, 255);
            tbPwd.BorderColorDisabled = Color.Silver;
            tbPwd.BorderColorIdle = Color.Black;

            txbUsername.BorderColorActive = Color.DodgerBlue;
            txbUsername.BorderColorHover = Color.FromArgb(105, 181, 255);
            txbUsername.BorderColorDisabled = Color.Silver;
            txbUsername.BorderColorIdle = Color.Black;

            btnSendMail.Enabled = false;
            viewData();
        }
        private void SendEmail(string recipientEmail, NekoItem item)
        {
            try
            {
                var email = new MimeMessage();

                email.From.Add(new MailboxAddress("Neko Coffee", "nekocoffe.app@gmail.com"));
                email.To.Add(new MailboxAddress("Client", recipientEmail));

                email.Subject = "[Neko Coffee] - Đổi Điểm Nhận Quà";

                // Tạo nội dung email dạng HTML
                var bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = $@"
<p style=""color: black;"">Xin chào,</p>
<p style=""color: black;"">Chúng tôi nhận được yêu cầu đổi quà từ bạn cho email này trên Neko Coffe App, với thông tin như sau: </b></p>
<p style=""color: black;"">Mã số: {item.ID} - Tên sản phẩm: {item.Name} - Điểm: {Item.Point}. <br>Quà sẽ được vận chuyển từ 1 đến 4 ngày tuỳ theo vị trí địa lý và dịch vụ<br> 
<p style=""color: black;"">Số điểm còn lại của bạn là: {int.Parse(tbPoint.Text) - int.Parse(this.Item.Point)}.Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi!. <br><br>
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
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn gửi email?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Nếu người dùng chọn OK, thực hiện gửi email
            if (result == DialogResult.OK)
            {
                SendEmail(tbEmail.Text, this.Item);
                UserUpdate_Click(sender, e);
                

            }
            btnRefresh_Click(sender, e);
        }

        private void UserView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
