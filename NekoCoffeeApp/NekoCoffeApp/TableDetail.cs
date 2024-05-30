using FireSharp;
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
using System.Windows.Documents;
using System.Windows.Forms;

namespace UI
{
    public partial class TableDetail : Form
    {
        DataTable mydt = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public TableDetail() {}
        private NekoTable _table;
        public TableDetail(NekoTable table)
        {
            InitializeComponent();
            _table = table;
            LoadTableDetails();
        }
        private async void LoadTableDetails()
        {

        }

        private async void TableDetail_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            mydt.Columns.Add("Ten Mon");
            mydt.Columns.Add("SL");
            mydt.Columns.Add("Thanh Tien");

            dataGridView1.DataSource = mydt;
            var response = await client.GetAsync("/Drinks");
            var drinks = JsonConvert.DeserializeObject<Dictionary<string, NekoDrink>>(response.Body);
            foreach (var drink in drinks.Values)
            {
                comboBox1.Items.Add(drink.Name);
            }
            var response1 = await client.GetAsync("/Cats");
            var cats = JsonConvert.DeserializeObject<Dictionary<string, NekoCat>>(response1.Body);
            foreach (var cat in cats.Values)
            {
                comboBox2.Items.Add(cat.Name);
            }
        }

        private void TableDetailsAdd_Click(object sender, EventArgs e)
        {

        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn hay không
            if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một mục từ sản phẩm.");
                return;
            }
            // Kiểm tra xem có nhiều hơn một mục được chọn hay không
            else if (comboBox1.SelectedIndex >= 0 && comboBox2.SelectedIndex >= 0)
            {
                MessageBox.Show("Vui lòng chỉ chọn một mục từ sản phẩm.");
                return;
            }

            int selectedNumber = (int)numericUpDown1.Value;
            string selectedItem;
            int money = 0;

            // Lấy mục được chọn từ ComboBox1 hoặc ComboBox2
            if (comboBox1.SelectedIndex >= 0)
            {
                selectedItem = comboBox1.SelectedItem.ToString();
                var response = await client.GetAsync("/Drinks");
                var drinks = JsonConvert.DeserializeObject<Dictionary<string, NekoDrink>>(response.Body);
                foreach (var drink in drinks.Values)
                {
                    if (drink.Name == selectedItem)
                    {
                        if (int.TryParse(drink.Price, out int price))
                        {
                            money = price * selectedNumber;
                        }
                    }
                }
            }
            else
            {
                selectedItem = comboBox2.SelectedItem.ToString();
                var response = await client.GetAsync("/Cats");
                var drinks = JsonConvert.DeserializeObject<Dictionary<string, NekoCat>>(response.Body);
                foreach (var drink in drinks.Values)
                {
                    if (drink.Name == selectedItem)
                    {
                        if (int.TryParse(drink.Price, out int price))
                        {
                            money = price * selectedNumber;
                        }
                    }
                }
            }

            // Lấy dữ liệu từ Firebase

            // Tạo dữ liệu chi tiết bàn
            var data = new NekoTableDetail
            {
                Name = selectedItem,
                SL = selectedNumber,
                Total = money
            };

            // Lưu dữ liệu chi tiết bàn vào Firebase
            SetResponse response1 = await client.SetAsync("TableDetails/" + _table.ID + "/" + selectedItem, data);
            if (response1.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Đã thêm mục thành công!");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm mục.");
            }

            // Reset các control
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            numericUpDown1.Value = 0;
        }

        private async void TableDetailsView_Click(object sender, EventArgs e)
        {
            /*mydt.Rows.Clear();
            FirebaseResponse resp = await client.GetAsync("1/");
            var data = resp.ResultAs<Dictionary<string, string>>();
            if (data == null)
            {
                MessageBox.Show("Ban chua duoc su dung");
            }
            else
            {
                foreach (var item in data)
                {
                    DataRow row = mydt.NewRow();
                    row["Tenmon"] = item.Key; // Khóa là tên món
                    row["SL"] = item.Value;   // Giá trị là số lượng
                    mydt.Rows.Add(row);
                }
            }*/
        }
    }
}

