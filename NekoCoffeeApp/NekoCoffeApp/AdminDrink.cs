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
               string.IsNullOrWhiteSpace(AdminFillDrinkName.Text) ||
               string.IsNullOrWhiteSpace(AdminFillDrinkType.Text) ||
               string.IsNullOrWhiteSpace(AdminFillDrinkPrice.Text) ||
               string.IsNullOrWhiteSpace(AdminFillDrinkAvailable.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = drk.Get(@"Drinks/" + AdminFillDrinkName.Text);
            NekoDrink ResDrink = res.ResultAs<NekoDrink>();

            NekoDrink CurDrink = new NekoDrink()
            {
                Name = AdminFillDrinkName.Text
            };

            if (NekoDrink.Search(ResDrink, CurDrink))
            {
                NekoDrink.ShowError_2();
                return;
            }

            NekoDrink drink = new NekoDrink()
            {
                Name = AdminFillDrinkName.Text,
                Available = AdminFillDrinkAvailable.Text,
                Price = AdminFillDrinkPrice.Text,
                Type = AdminFillDrinkType.Text
            };

            SetResponse set = drk.Set(@"Drinks/" + AdminFillDrinkType.Text, drink);


            if (set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Thêm thành công nước {AdminFillDrinkName.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    string.IsNullOrWhiteSpace(AdminFillDrinkName.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá nước?", "Xác nhận xoá", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    var delete = drk.Delete(@"Drinks/" + AdminFillDrinkName.Text);
                    if (delete.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show($"Xoá nước {AdminFillDrinkName.Text} thành công!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminFillDrinkName.Clear();
                    }
                }
                else
                {
                    return;
                }
                viewData();

            
        }
    }
}
