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
using BCrypt.Net;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using Aspose.Email.Clients.ActiveSync.TransportLayer;
using Aspose.Email.PersonalInfo;
using System.Text.RegularExpressions;
using FireSharp;

namespace Master_NekoCoffeeApp
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        private void User_Load(object sender, EventArgs e)
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
            UserAdd.Enabled = true;
            UserUpdate.Enabled = false;
            UserDelete.Enabled = false;

        }
        void viewData()
        {
            var data = client.Get(@"/Users");

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

            var listNumber = mList.Values.ToList();
            UserView.DataSource = listNumber;
        }


        private async void AdminAddDrink_Click(object sender, EventArgs e)
        {
            if (
               string.IsNullOrWhiteSpace(txbUsername.Text) ||
               string.IsNullOrWhiteSpace(tbPwd.Text) ||
               string.IsNullOrWhiteSpace(tbEmail.Text) ||
               string.IsNullOrWhiteSpace(tbPhone.Text) ||
               string.IsNullOrWhiteSpace(dbGender.Text) ||
               string.IsNullOrWhiteSpace(tbFullname.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            if ((ResUser != null && MasterUser.Search(ResUser, CurUser)) || NekoResUser != null && NekoUser.Search(NekoResUser, NekoCurUser))
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
            };

            SetResponse set = await client.SetAsync("Users/" + txbUsername.Text, user);


            if (set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Đăng ký thành công tài khoản {txbUsername.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show($"Đăng ký không thành công tài khoản!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            tbUsername.Clear();
            txbUsername.Clear();
            tbPwd.Clear();
            dbGender.Text = string.Empty; // Đặt giá trị hiển thị về rỗng
            tbFullname.Clear();
            tbEmail.Clear();
            tbPoint.Clear();
            tbType.Clear();
            tbPhone.Clear();
            tbDate.Clear();
            UserAdd.Enabled = true;
            UserUpdate.Enabled = false;
            UserDelete.Enabled = false;
            viewData();

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
        private void AdminCheckDrink_Click(object sender, EventArgs e)
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
            UserAdd.Enabled = false;
            UserUpdate.Enabled = true;
            UserDelete.Enabled = true;


        }

        private void UserDelete_Click(object sender, EventArgs e)
        {

        }

        private async void UserUpdate_Click(object sender, EventArgs e)
        {
            if (
                 string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                    MessageBox.Show("Bạn không được phép đổi thông tin tài khoản Master khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var updateData = new NekoUser
                {
                    Username = user.Username,
                    Password = user.Password,
                    Fullname = tbFullname.Text,
                    Gender = dbGender.Text,
                    PhoneNumber = tbPhone.Text,
                    Email = tbEmail.Text.ToLower(),
                    Position = "KH",
                    RegistrationDate = user.RegistrationDate, // giữ nguyên ngày đăng ký
                    Point = user.Point // giữ nguyên điểm
                };

                SetResponse up = await client.SetAsync("Users/" + txbUsername.Text, updateData);
                if (up.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"Sửa thông tin thành công tài khoản {txbUsername.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thông tin thất bại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnRefresh_Click(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
            txbUsername.Clear();
            tbPwd.Clear();
            tbFullname.Clear();
            tbEmail.Clear();
            tbPoint.Clear();
            tbType.Clear();
            tbPhone.Clear();
            tbDate.Clear();
            UserAdd.Enabled = true;
            UserUpdate.Enabled = false;
            UserDelete.Enabled = false;
            dbGender.Text = string.Empty; // Đặt giá trị hiển thị về rỗng

            tbPwd.BorderColorActive = Color.DodgerBlue;
            tbPwd.BorderColorHover = Color.FromArgb(105, 181, 255);
            tbPwd.BorderColorDisabled = Color.Silver;
            tbPwd.BorderColorIdle = Color.Black;

            txbUsername.BorderColorActive = Color.DodgerBlue;
            txbUsername.BorderColorHover = Color.FromArgb(105, 181, 255);
            txbUsername.BorderColorDisabled = Color.Silver;
            txbUsername.BorderColorIdle = Color.Black;

            viewData();
        }
    }




}
