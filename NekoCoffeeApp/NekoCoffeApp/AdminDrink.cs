using Aspose.Email.Clients.Exchange.WebService.Schema_2016;
using Aspose.Email.PersonalInfo;
using BCrypt.Net;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.LinkLabel;

namespace UI
{
    public partial class AdminDrink : UserControl
    {

        public AdminDrink()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient drk;

        private void AdminDrink_Load_1(object sender, EventArgs e)
        {
            try
            {
                drk = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            viewData();
        }



        private void AdminAddDrink_Click(object sender, EventArgs e)
        {
            if (
               string.IsNullOrWhiteSpace(AdminFillDrinkID.Text) ||
               string.IsNullOrWhiteSpace(AdminFillDrinkType.Text) ||
               string.IsNullOrWhiteSpace(AdminFillDrinkPrice.Text) ||
               string.IsNullOrWhiteSpace(AdminFillDrinkAvailable.Text) ||
               string.IsNullOrWhiteSpace(AdminFillDrinkName.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = drk.Get(@"Drinks/" + AdminFillDrinkID.Text);
            NekoDrink ResDrink = res.ResultAs<NekoDrink>();

            NekoDrink CurDrink = new NekoDrink()
            {
                Name = AdminFillDrinkID.Text
            };

            if (NekoDrink.Search(ResDrink, CurDrink))
            {
                NekoDrink.ShowError_2();
                return;
            }

            NekoDrink drink = new NekoDrink()
            {
                ID = AdminFillDrinkID.Text,
                Name = AdminFillDrinkID.Text,
                Available = AdminFillDrinkAvailable.Text,
                Price = AdminFillDrinkPrice.Text,
                Type = AdminFillDrinkType.Text
            };

            SetResponse set = drk.Set(@"Drinks/" + AdminFillDrinkID.Text, drink);


            if (set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Thêm thành công nước {AdminFillDrinkID.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewData();
            }
        }




        void viewData()
        {
            var data = drk.Get(@"/Drinks");
            var mList = JsonConvert.DeserializeObject<IDictionary<string, NekoDrink>>(data.Body);
            var listNumber = mList.Values.ToList();
            AdminViewAllYourDrinks.DataSource = listNumber;
        }

        private void AdminShowAllDrinks_Click(object sender, EventArgs e)
        {

        }

        private void AdminDeleteDrink_Click(object sender, EventArgs e)
        {

            if (
                string.IsNullOrWhiteSpace(AdminFillDrinkID.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = drk.Get(@"Drinks/" + AdminFillDrinkID.Text);
            NekoDrink ResDrink = res.ResultAs<NekoDrink>();

            NekoDrink CurDrink = new NekoDrink()
            {
                ID = AdminFillDrinkID.Text
            };

            if (!NekoDrink.IsExist(ResDrink, CurDrink))
            {
                NekoDrink.ShowError_3();
                return;
            }
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá nước?", "Xác nhận xoá", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                var delete = drk.Delete(@"Drinks/" + AdminFillDrinkID.Text);
                if (delete.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"Xoá nước {AdminFillDrinkID.Text} thành công!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminFillDrinkID.Clear();
                    AdminFillDrinkName.Clear();
                    AdminFillDrinkAvailable.Clear();
                    AdminFillDrinkPrice.Clear();
                    AdminFillDrinkSearch.Clear();
                    AdminFillDrinkType.Clear();
                }
            }
            else
            {
                return;
            }
            viewData();


        }

        private void AdminUpdateDrink_Click(object sender, EventArgs e)
        {

            FirebaseResponse res = drk.Get(@"Drinks/" + AdminFillDrinkID.Text);
            NekoDrink ResDrink = res.ResultAs<NekoDrink>();

            NekoDrink CurDrink = new NekoDrink()
            {
                ID = AdminFillDrinkID.Text
            };

            if (!NekoDrink.IsExist(ResDrink, CurDrink))
            {
                NekoDrink.ShowError_3();
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                NekoDrink drink = new NekoDrink()
                {
                    ID = AdminFillDrinkID.Text,
                    Name = AdminFillDrinkName.Text,
                    Available = AdminFillDrinkAvailable.Text,
                    Price = AdminFillDrinkPrice.Text,
                    Type = AdminFillDrinkType.Text
                };

                FirebaseResponse update = drk.Update(@"Drinks/" + AdminFillDrinkID.Text, drink);


                if (update.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"Sửa thành công nước {AdminFillDrinkID.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else { return; }
                viewData();
            }
        }

        private void AdminCheckDrink_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AdminFillDrinkSearch.Text))
            {
                MessageBox.Show("Vui lòng điền mã nước", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = drk.Get(@"Drinks/" + AdminFillDrinkSearch.Text);
            NekoDrink existingDrink = res.ResultAs<NekoDrink>();

            if (existingDrink == null)
            {
                MessageBox.Show("Nước không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AdminFillDrinkID.Text = existingDrink.ID;
            AdminFillDrinkName.Text = existingDrink.Name;
            AdminFillDrinkType.Text = existingDrink.Type;
            AdminFillDrinkPrice.Text = existingDrink.Price;
            AdminFillDrinkAvailable.Text = existingDrink.Available;
        }

        private void AdminViewAllYourDrinks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminFillDrinkPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminFillDrinkAvailable_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
