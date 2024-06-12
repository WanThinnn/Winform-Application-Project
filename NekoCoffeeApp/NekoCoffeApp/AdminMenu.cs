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
            int book =0, avai=0;
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

        private void AdminComePayment_Click(object sender, EventArgs e)
        {

        }

        private void AdminComeOder_Click(object sender, EventArgs e)
        {

        }
    }
}
