using FireSharp.Config;
using FireSharp.Interfaces;
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
using static Bunifu.UI.WinForms.BunifuSnackbar;

namespace UI
{
    public partial class AdminOrder : UserControl
    {


        private static AdminOrder _instance;
        public static AdminOrder Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminOrder();
                return _instance;
            }
        }

        public AdminOrder()
        {
            InitializeComponent();

        }

        private void AdminOrderBtn_Click(object sender, EventArgs e)
        {
            edit_Order edit_Order = new edit_Order();
            edit_Order.Show(); 
        }


        private void AdminOrder_Load(object sender, EventArgs e)
        {
            try
            {
                tbl = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadTable();

        }

        private void AdminOrderTable1_Click(object sender, EventArgs e)
        {
            TableDetail tableDetail = new TableDetail();
            tableDetail.Show();
        }


        private void AdminAdjustTable_Click(object sender, EventArgs e)
        {
            edit_Table edit_Table = new edit_Table();
            edit_Table.Show();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient tbl;


        private void AdminLoadTablesBtn_Click(object sender, EventArgs e)
        {
            // Xóa các controls cũ trên AdminOrderPanel nếu có
            Table_flowLayoutPanel.Controls.Clear();
            LoadTable();

        }
        // Lặp qua danh sách các bảng và thêm thông tin những bảng có trạng thái "Booked"
        async void LoadTable()
        {
            var response = await tbl.GetAsync("/Tables");
            var tables = JsonConvert.DeserializeObject<Dictionary<string, NekoTable>>(response.Body);
            foreach (var table in tables.Values)
            {
                // Tạo một nút mới để hiển thị thông tin bảng

                Button btn = new Button();
                btn.Size = new Size(109, 109); // Thiết lập kích thước
                if (table.Status == "Booked")
                {
                    btn.BackColor = Color.Gray; 
                    btn.Enabled = false;
                }
                else
                {
                    btn.Enabled= true;
                    btn.BackColor = Color.LightBlue; // Thiết lập màu sắc
                }
                btn.Text = $"ID: {table.ID}\nName: {table.Name}\nStatus: {table.Status}";

                // Gán sự kiện Click cho nút
                btn.Click += (s, args) => OpenTableDetail(table);
                Table_flowLayoutPanel.Controls.Add(btn);
            }
        }
        void OpenTableDetail(NekoTable table)
        {
            // Khởi tạo form chi tiết bảng với thông tin bảng được truyền vào
            TableDetail tableDetail = new TableDetail(table);
            tableDetail.Show();
        }

        private void AdminOrderBtn_Click_1(object sender, EventArgs e)
        {
            edit_Order edit_Order = new edit_Order();
            edit_Order.Show();
        }

        private void Table_flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
