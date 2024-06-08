using Bunifu.UI.WinForms;
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

namespace UI
{
    public partial class AdminTable : UserControl 
    {
        public event EventHandler<NekoTable> TableAdded;




        public AdminTable()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient tb;

        private void AdminTable_Load(object sender, EventArgs e)
        {
            try
            {
                tb = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            viewData();
        }

        async void viewData()
        {
            if (tb == null)
            {
                MessageBox.Show("Tham chiếu bảng là null.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var data = await tb.GetAsync("Tables");

            // Kiểm tra nếu data hoặc data.Body là null
            if (data == null || data.Body == null)
            {
                MessageBox.Show("Không có dữ liệu nào được lấy từ Firebase.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string jsonData = data.Body;

            // Kiểm tra xem jsonData có phải là mảng JSON không
            if (jsonData.TrimStart().StartsWith("["))
            {
                var mListArray = JsonConvert.DeserializeObject<List<NekoTable>>(jsonData);

                // Kiểm tra nếu mListArray là null hoặc rỗng
                if (mListArray == null || !mListArray.Any())
                {
                    MessageBox.Show("Không tìm thấy nhân viên nào.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Loại bỏ các giá trị null
                var filteredList = mListArray.Where(item => item != null).ToList();

                // Kiểm tra nếu filteredList là null hoặc rỗng
                if (filteredList == null || !filteredList.Any())
                {
                    MessageBox.Show("Không tìm thấy nhân viên nào sau khi lọc bỏ các giá trị null.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Sử dụng filteredList làm nguồn dữ liệu cho DataGridView
                bunifuDataGridView1.DataSource = filteredList;
            }
        }

        private void AdminAddTable_Click(object sender, EventArgs e)
        {
            if (
              string.IsNullOrWhiteSpace(AdminFillTableID.Text) ||
              string.IsNullOrWhiteSpace(AdminFillTableName.Text) ||
              string.IsNullOrWhiteSpace(comboBox1.SelectedItem.ToString()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FirebaseResponse res = tb.Get(@"Tables/" + AdminFillTableID.Text);
            NekoTable ResTable = res.ResultAs<NekoTable>();

            NekoTable CurTable = new NekoTable()
            {
                ID = AdminFillTableID.Text
            };

            if (NekoTable.Search(ResTable, CurTable))
            {
                NekoTable.ShowError_3();
                return;
            }

            NekoTable table = new NekoTable()
            {
                ID = AdminFillTableID.Text,
                Name = AdminFillTableID.Text,
                Status = comboBox1.SelectedItem.ToString()
            };

            SetResponse set = tb.Set(@"Tables/" + AdminFillTableID.Text, table);


            if (set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Thêm thành công bàn {AdminFillTableID.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TableAdded?.Invoke(this, table); // Kích hoạt sự kiện TableAdded
                viewData();
            }

            AddNewTableToForm(table);
        }

        private void AddNewTableToForm(NekoTable table)
        {
            // Tạo một PictureBox mới để đại diện cho bàn mới
            PictureBox pictureBoxTable = new PictureBox();
            pictureBoxTable.Tag = table; 
            pictureBoxTable.Width = 100; 
            pictureBoxTable.Height = 100; 
            pictureBoxTable.BackColor = Color.LightGray;
            pictureBoxTable.Click += PictureBoxTable_Click; 

            pictureBoxTable.Location = new Point(10 + 140 * this.Controls.OfType<PictureBox>().Count(), 10);

            // Thêm PictureBox vào form 
            this.Controls.Add(pictureBoxTable);
            //RemovePictureBox(pictureBoxTable);

        }

        private void PictureBoxTable_Click(object sender, EventArgs e)
        {
            //PictureBox pictureBox = sender as PictureBox;
            //if (pictureBox != null)
            //{
            //    NekoTable table = pictureBox.Tag as NekoTable;
            //    if (table != null)
            //    {
            //        LoadTableDetails(table);
            //    }
            //}
        }

        private void RemovePictureBox(PictureBox pictureBox)
        {
            this.Controls.Remove(pictureBox);
        }

        private void AdminCheckTable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AdminFillTableID.Text))
            {
                MessageBox.Show("Vui lòng điền mã số nhân viên!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FirebaseResponse res = tb.Get("/Tables/" + AdminFillTableID.Text);
            NekoTable emp = res.ResultAs<NekoTable>();
            if (emp == null)
            {
                MessageBox.Show("Bàn không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AdminFillTableName.Text = emp.Name;
            comboBox1.SelectedItem = emp.Status;
        }

        private void AdminTablesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AdminFillTableID.Text = "";
            AdminFillTableName.Text = "";
            comboBox1.SelectedItem = null;
            DataGridViewRow row = new DataGridViewRow();
            row = bunifuDataGridView1.Rows[e.RowIndex];
            AdminFillTableID.Text = Convert.ToString(row.Cells[0].Value);
            AdminFillTableName.Text = Convert.ToString(row.Cells[1].Value);
            foreach (string s in comboBox1.Items)
            {
                if (s == Convert.ToString(row.Cells[2].Value))
                {
                    comboBox1.SelectedItem = Convert.ToString(row.Cells[2].Value);
                }
            }
        }

        private async void AdminDeleteTable_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn xóa bàn này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                FirebaseResponse response = await tb.DeleteAsync(@"Tables/" + AdminFillTableID.Text);
                MessageBox.Show("Đã xóa bàn thành công !!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
