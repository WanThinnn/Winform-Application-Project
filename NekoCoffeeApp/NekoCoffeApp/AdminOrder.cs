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
            // Đảm bảo tbl không null trước khi cố gắng sử dụng nó
            if (tbl == null)
            {
                MessageBox.Show("Tham chiếu bảng là null.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var data = await tbl.GetAsync("Tables");

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
                // Nếu là mảng JSON, xử lý nó như một danh sách
                var mListArray = JsonConvert.DeserializeObject<List<NekoTable>>(jsonData);

                // Kiểm tra nếu mListArray là null hoặc rỗng
                if (mListArray == null || !mListArray.Any())
                {
                    MessageBox.Show("Không tìm thấy nhân viên nào.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Đảm bảo Table_flowLayoutPanel không null trước khi sử dụng
                if (Table_flowLayoutPanel == null)
                {
                    MessageBox.Show("Bảng điều khiển bố trí dòng chưa được khởi tạo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (var table in mListArray)
                {
                    // Kiểm tra nếu table là null
                    if (table == null)
                    {
                        continue;
                    }

                    // Tạo một nút mới để hiển thị thông tin bảng
                    Button btn = new Button();
                    btn.Size = new Size(109, 109); // Thiết lập kích thước

                    var bookingData = await tbl.GetAsync($"Tables/{table.ID}/Bookings");
                    bool hasBookings;
                    if (bookingData == null)
                    {
                        hasBookings = false;
                    }
                    else
                    {
                        hasBookings = true;
                    }

                    if (table.Status == "Booked" && hasBookings) 
                    {
                        btn.BackColor = Color.DeepSkyBlue; // Dark blue if booking details are present
                    }
                    else if (table.Status == "Booked")
                    {
                        btn.BackColor = Color.Gray; // Gray if status is booked but no booking details
                    }
                    else
                    {
                        btn.BackColor = Color.LightBlue; // Light blue if available
                    }

                    btn.Text = $"ID: {table.ID}\nName: {table.Name}\nStatus: {table.Status}";
                    
                    // Gán sự kiện Click cho nút
                    btn.Click += (s, args) => OpenTableDetail(table);
                    Table_flowLayoutPanel.Controls.Add(btn);
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu JSON không ở định dạng mong đợi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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