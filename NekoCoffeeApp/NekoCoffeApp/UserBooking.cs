using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class UserBooking : UserControl
    {
        private static UserBooking _instance;
        public static UserBooking Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserBooking();
                return _instance;
            }
        }

        IFirebaseClient client;

        private IFirebaseConfig firebaseConfig = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        public UserBooking()
        {
            InitializeComponent();
        }

        private void UserBooking_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(firebaseConfig);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến Firebase: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadTables();
        }

        private void LoadTables()
        {
            if (client == null)
            {
                MessageBox.Show("Tham chiếu Firebase không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var response = client.Get("Tables");

                if (response == null || response.Body == null)
                {
                    MessageBox.Show("Không có dữ liệu từ Firebase.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string jsonData = response.Body;

                if (jsonData.TrimStart().StartsWith("["))
                {
                    var tableList = JsonConvert.DeserializeObject<List<NekoTable>>(jsonData);

                    if (tableList == null || !tableList.Any())
                    {
                        MessageBox.Show("Không tìm thấy bàn nào.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    Table_flowLayoutPanel.Controls.Clear();

                    foreach (var table in tableList)
                    {
                        if (table == null)
                        {
                            continue;
                        }

                        Button btn = new Button();
                        btn.Size = new Size(109, 109);

                        if (table.Status == "Booked" || table.Status == "Using")
                        {
                            btn.BackColor = Color.Gray;
                            btn.Enabled = false;
                        }
                        else
                        {
                            btn.BackColor = Color.LightBlue;
                        }

                        btn.Text = $"ID: {table.ID}\nTên: {table.Name}\nTrạng thái: {table.Status}";

                        var tempTable = table; // Sử dụng biến tạm thời để giữ giá trị của table

                        btn.Click += (s, args) =>
                        {
                            GlobalVars.CurrentTable = tempTable;
                            BookingTable(GlobalVars.CurrentTable);
                        };

                        Table_flowLayoutPanel.Controls.Add(btn);
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu JSON không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BookingTable(NekoTable table)
        {
            if (table == null)
            {
                MessageBox.Show("Bàn được truyền vào là null.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GlobalVars.CurrentUser == null)
            {
                MessageBox.Show("Bạn cần đăng nhập để đặt bàn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Xác nhận đặt bàn {table.ID}?", "Thông tin", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            var response = await client.GetAsync("Tables");

            if (response == null || response.Body == null)
            {
                MessageBox.Show("Không có dữ liệu từ Firebase.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GlobalVars.CurrentUser.hasBooking == "true")
            {
                MessageBox.Show("Bạn đã đặt bàn rồi, không thể đặt thêm bàn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var booking = new Booking
            {
                Username = GlobalVars.CurrentUser.Username,
                FullName = GlobalVars.CurrentUser.Fullname,
                PhoneNumber = GlobalVars.CurrentUser.PhoneNumber,
                BookingTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            try
            {
                PushResponse pushResponse = await client.PushAsync($"Tables/{table.ID}/Bookings/{GlobalVars.CurrentUser.Username}", booking);

                if (pushResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    table.Status = "Booked";
                    GlobalVars.CurrentUser.hasBooking = "true";
                    SetResponse res = await client.SetAsync($"Users/{GlobalVars.CurrentUser.Username}", GlobalVars.CurrentUser);
                    SetResponse updateResponse = await client.SetAsync($"Tables/{table.ID}/Status", "Booked");

                    if (updateResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Đặt bàn thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTables(); // Làm mới danh sách bàn
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật trạng thái bàn không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Đặt bàn không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đặt bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task UpdateTableStatus(string tableId, string status)
        {
            try
            {
                var updateTable = new NekoTable
                {
                    ID = tableId,
                    Status = status
                };

                FirebaseResponse response = await client.SetAsync($"Tables/{tableId}", updateTable);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Cập nhật trạng thái bàn thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật trạng thái bàn không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật trạng thái bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Table_flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
