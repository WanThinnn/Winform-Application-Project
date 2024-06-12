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

        public UserBooking()
        {
            InitializeComponent();
        }

        private void UserBooking_Load(object sender, EventArgs e)
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

        async void LoadTable()
        {
            if (tbl == null)
            {
                MessageBox.Show("Tham chiếu bảng là null.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var data = await tbl.GetAsync("Tables");

            if (data == null || data.Body == null)
            {
                MessageBox.Show("Không có dữ liệu nào được lấy từ Firebase.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string jsonData = data.Body;

            if (jsonData.TrimStart().StartsWith("["))
            {
                var mListArray = JsonConvert.DeserializeObject<List<NekoTable>>(jsonData);

                if (mListArray == null || !mListArray.Any())
                {
                    MessageBox.Show("Không tìm thấy bàn nào.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (Table_flowLayoutPanel == null)
                {
                    MessageBox.Show("Bảng điều khiển bố trí dòng chưa được khởi tạo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Table_flowLayoutPanel.Controls.Clear(); // Clear existing buttons before loading new ones

                foreach (var table in mListArray)
                {
                    if (table == null)
                    {
                        continue;
                    }

                    Button btn = new Button();
                    btn.Size = new Size(109, 109);

                    var bookingData = await tbl.GetAsync($"Tables/{table.ID}/Bookings");
                    bool hasBookings = bookingData != null && bookingData.Body != "null";

                    if (table.Status != null && table.Status == "Booked")
                    {
                        btn.BackColor = Color.Gray;
                    }
                    else if (hasBookings)
                    {
                        btn.BackColor = Color.DarkBlue; // Dark blue if booking details are present
                    }
                    else
                    {
                        btn.BackColor = Color.LightBlue;
                    }

                    btn.Text = $"ID: {table.ID}\nName: {table.Name}\nStatus: {table.Status}";

                    btn.Click += (s, args) => BookingTable(table);
                    Table_flowLayoutPanel.Controls.Add(btn);
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu JSON không ở định dạng mong đợi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        async void BookingTable(NekoTable table)
        {
            if (GlobalVars.CurrentUser == null)
            {
                MessageBox.Show("User not logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo thông tin đặt bàn mới
            var booking = new Booking
            {
                Username = GlobalVars.CurrentUser.Username,
                FullName = GlobalVars.CurrentUser.Fullname,
                PhoneNumber = GlobalVars.CurrentUser.PhoneNumber,
                BookingTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            try
            {
                // Thêm thông tin đặt bàn vào thông tin con của bảng cụ thể
                PushResponse response = await tbl.PushAsync($"Tables/{table.ID}/Bookings", booking);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // Đặt trạng thái của bàn là "Booked"
                    table.Status = "Booked";
                    SetResponse updateResponse = await tbl.SetAsync($"Tables/{table.ID}/Status", "Booked");

                    if (updateResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Table booked successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTable(); // Refresh the table list
                    }
                    else
                    {
                        MessageBox.Show("Failed to update table status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to book the table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error booking the table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
