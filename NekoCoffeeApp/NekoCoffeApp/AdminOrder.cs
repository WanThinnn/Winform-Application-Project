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




        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }







        private void AdminOrder_Load(object sender, EventArgs e)
        {

        }

        private void AdminOrderTable1_Click(object sender, EventArgs e)
        {
            TableDetail tableDetail = new TableDetail();
            tableDetail.Show();
        }



        private void AdminOrderPanel_Click(object sender, EventArgs e)
        {

        }

        private void AdminAdjustTable_Click(object sender, EventArgs e)
        {
            edit_Table edit_Table = new edit_Table();
            edit_Table.Show();
        }

        private void AdminLoadTablesBtn_Click(object sender, EventArgs e)
        {

            List<NekoTable> tables = new List<NekoTable>
        {
            new NekoTable { ID = "1", Name = "Table 1", Status = "Booked" },
            new NekoTable { ID = "2", Name = "Table 2", Status = "Booked" },
            new NekoTable { ID = "3", Name = "Table 3", Status = "Booked" },
            new NekoTable { ID = "5", Name = "Table 3", Status = "Booked" },
            new NekoTable { ID = "6", Name = "Table 3", Status = "Booked" },
            new NekoTable { ID = "7", Name = "Table 3", Status = "Booked" },
            new NekoTable { ID = "4", Name = "Table 4", Status = "Booked" }
        };

            // Xóa các controls cũ trên flowLayoutPanel1 nếu có
            flowLayoutPanel1.Controls.Clear();

            // Lặp qua danh sách các bảng và thêm thông tin những bảng có trạng thái "Booked"
            foreach (var table in tables)
            {
                if (table.Status == "Booked")
                {
                    // Tạo một nút mới để hiển thị thông tin bảng
                    Button btn = new Button();
                    btn.Size = new Size(109, 109); // Thiết lập kích thước
                    btn.BackColor = Color.LightBlue; // Thiết lập màu sắc
                    btn.Text = $"ID: {table.ID}\nName: {table.Name}\nStatus: {table.Status}";

                    btn.Click += (s, args) => OpenTableDetail(table);


                    flowLayoutPanel1.Controls.Add(btn);



                }
            }

            void OpenTableDetail(NekoTable table)
            {
                // Khởi tạo form chi tiết bảng với thông tin bảng được truyền vào
                TableDetail tableDetail = new TableDetail(table);
                tableDetail.Show();
            }
        }


        
    }
}
