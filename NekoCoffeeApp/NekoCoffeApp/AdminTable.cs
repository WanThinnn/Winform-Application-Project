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

        void viewData()
        {
            var data = tb.Get(@"/Tables");
            var mList = JsonConvert.DeserializeObject<IDictionary<string, NekoTable>>(data.Body);
            var listNumber = mList.Values.ToList();
            AdminTablesView.DataSource = listNumber;
        }

        private void AdminAddTable_Click(object sender, EventArgs e)
        {
            if (
              string.IsNullOrWhiteSpace(AdminFillTableID.Text) ||
              string.IsNullOrWhiteSpace(AdminFillTableName.Text) ||
              string.IsNullOrWhiteSpace(AdminFillTableStatus.Text))
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
                Status = AdminFillTableStatus.Text
            };

            SetResponse set = tb.Set(@"Tables/" + AdminFillTableID.Text, table);


            if (set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Thêm thành công nước {AdminFillTableID.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
}
