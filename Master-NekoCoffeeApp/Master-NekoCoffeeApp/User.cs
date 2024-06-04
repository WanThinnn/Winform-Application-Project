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
        }
        void viewData()
        {
            var data = client.Get(@"/Users");
            var mList = JsonConvert.DeserializeObject<IDictionary<string, NekoUser>>(data.Body);
            var listNumber = mList.Values.ToList();
            UserView.DataSource = listNumber;
        }

        private async void AdminAddDrink_Click(object sender, EventArgs e)
        {
            if (
               string.IsNullOrWhiteSpace(tbUsername.Text) ||
               string.IsNullOrWhiteSpace(tbPwd.Text) ||
               string.IsNullOrWhiteSpace(tbGender.Text) ||
               string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = await client.GetAsync("MasterUsers/" + tbUsername.Text);
            FirebaseResponse nekores = await client.GetAsync("Users/" + tbUsername.Text);
            MasterUser ResUser = res.ResultAs<MasterUser>();
            NekoUser NekoResUser = nekores.ResultAs<NekoUser>();

            MasterUser CurUser = new MasterUser()
            {
                Username = tbUsername.Text
            };

            NekoUser NekoCurUser = new NekoUser()
            {
                Username = tbUsername.Text
            };

            // Nếu ResUser không phải là null, thực hiện kiểm tra
            if ((ResUser != null && MasterUser.Search(ResUser, CurUser)) || NekoResUser != null && NekoUser.Search(NekoResUser, NekoCurUser))
            {
                NekoUser.ShowError_2();
                return;
            }
            NekoUser user = new NekoUser()
            {
                Username = tbUsername.Text,
                Password = BCrypt.Net.BCrypt.EnhancedHashPassword(tbPwd.Text, hashType: HashType.SHA384),
                Fullname = tbFullname.Text,
                Gender = tbGender.Text,
                PhoneNumber = tbPhone.Text,
                Email = tbEmail.Text.ToLower(),
                Position = "KH",
                RegistrationDate = DateTime.Now, // Gán ngày đăng ký tại đây
                Point = 0,
            };

            SetResponse set = await client.SetAsync("Users/" + tbUsername.Text, user);
           

            if (set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Đăng ký thành công tài khoản {tbUsername.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show($"Đăng ký không thành công tài khoản!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            viewData();

        }
    }
    

    
    
}
