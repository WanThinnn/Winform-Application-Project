using Aspose.Email.Clients.Exchange.WebService.Schema_2016;
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
    public partial class AdminMenu : UserControl
    {
        private static AdminMenu _instance;
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public static AdminMenu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminMenu();
                return _instance;
            }
        }
        public AdminMenu()
        {
            InitializeComponent();

        }
        private async void AdminMenu_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(ifc);
            // Đảm bảo tbl không null trước khi cố gắng sử dụng nó
            checkprogress();
            checkpayment();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminTitle3_Click(object sender, EventArgs e)
        {
                    }

        private void MostRecentPay2_Click(object sender, EventArgs e)
        {
                    }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void AdminTableCircle_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {

        }

        private void AdminLabel3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        

        private void AdminComeOder_Click(object sender, EventArgs e)
        {

        }
        private async void checkpayment()
        {
            // Đảm bảo client không null trước khi cố gắng sử dụng nó
            if (client == null)
            {
                MessageBox.Show("Client chưa được khởi tạo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var data = await client.GetAsync("Bills");

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
                var billList = JsonConvert.DeserializeObject<List<Bills>>(jsonData);

                // Kiểm tra nếu billList là null hoặc rỗng
                if (billList == null || !billList.Any())
                {
                    MessageBox.Show("Không tìm thấy hóa đơn nào.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Lọc các hóa đơn có billId không null và chuyển đổi billId thành số nguyên
                var validBills = billList.Where(b => b != null && int.TryParse(b.billId, out _)).ToList();

                // Kiểm tra nếu validBills là null hoặc rỗng
                if (!validBills.Any())
                {
                    MessageBox.Show("Không có hóa đơn hợp lệ.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Sắp xếp các hóa đơn theo billId đã chuyển đổi sang số nguyên
                var topBills = validBills.OrderByDescending(b => int.Parse(b.billId)).Take(3).ToList();

                // Đảm bảo flowLayoutPanel1 không null trước khi sử dụng
                if (flowLayoutPanel1 == null)
                {
                    MessageBox.Show("Bảng điều khiển bố trí dòng chưa được khởi tạo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Xóa các control cũ trước khi thêm mới
                flowLayoutPanel1.Controls.Clear();

                foreach (var bill in topBills)
                {
                    // Kiểm tra các thuộc tính của bill để đảm bảo chúng không null
                    if (bill.tableId == null || bill.Total.ToString() == null)
                    {
                        continue;
                    }

                    // Tạo một BunifuButton mới để hiển thị thông tin hóa đơn
                    var btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                    btn.Size = new Size(290, 55); // Thiết lập kích thước
                    btn.IdleFillColor = Color.Black;
                    btn.IdleBorderColor = Color.Black;
                    btn.ForeColor = Color.LightSalmon;
                    btn.IdleBorderRadius = 35;
                    btn.Font = new Font("Century Gothic", 9, FontStyle.Regular);
                    // Thiết lập để tắt hiệu ứng hover
                    btn.onHoverState.BorderColor = Color.Black;
                    btn.onHoverState.FillColor = Color.Black;
                    btn.onHoverState.ForeColor = Color.LightSalmon;

                    // Thiết lập để tắt hiệu ứng khi click vào
                    btn.OnPressedState.BorderColor = Color.Black;
                    btn.OnPressedState.FillColor = Color.Black;
                    btn.OnPressedState.ForeColor = Color.LightSalmon;

                    btn.OnDisabledState.FillColor = Color.White;
                    btn.OnDisabledState.BorderColor = Color.White;
                    btn.OnDisabledState.ForeColor = Color.LightSalmon;


                    btn.ButtonText = $"Hoá đơn số: {bill.billId}\nBàn số : {bill.tableId}\nTổng cộng: {bill.Total}";

                    // Thêm button vào flowLayoutPanel1
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu JSON không ở định dạng mong đợi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void checkprogress()
        {
            int book = 0, avai = 0;
            if (client == null)
            {
                MessageBox.Show("Tham chiếu bảng là null.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var data = await client.GetAsync("Tables");

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
                    MessageBox.Show("Không tìm thấy bàn nào.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    if (table.Status != null && table.Status == "Booked")
                    {
                        book++;
                    }
                    else
                    {
                        avai++;
                    }
                    AdminBillCircle.Maximum = avai + book;
                    AdminTableCircle.Maximum = avai + book;
                    AdminTableCircle.Value = avai;
                    AdminBillCircle.Value = book;
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu JSON không ở định dạng mong đợi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(ifc);
            // Đảm bảo tbl không null trước khi cố gắng sử dụng nó
            checkprogress();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(ifc);
            // Đảm bảo tbl không null trước khi cố gắng sử dụng nó
            checkpayment();
        }
    }
}
