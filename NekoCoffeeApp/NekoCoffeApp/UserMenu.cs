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
using System.Windows.Input;
using static Bunifu.UI.WinForms.BunifuSnackbar;

namespace UI
{
    public partial class UserMenu : UserControl
    {

        private static UserMenu _instance;
        public static UserMenu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserMenu();
                return _instance;
            }
        }

        public UserMenu()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient tbl;

        private void UserMenu_Load(object sender, EventArgs e)
        {
            try
            {
                tbl = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Loaddrinks();
        }

        async void Loaddrinks()
        {
            var response = await tbl.GetAsync("/Drinks");
            var drinks = JsonConvert.DeserializeObject<Dictionary<string, NekoDrink>>(response.Body);

            foreach (var drink in drinks.Values)
            {
                // Tạo một panel mới cho mỗi drink
                Panel panel = new Panel();
                panel.Size = new Size(150, 150); // Thiết lập kích thước của Panel
                panel.BorderStyle = BorderStyle.FixedSingle; // Thêm viền cho Panel (tùy chọn)

                // Tạo một PictureBox để hiển thị ảnh của drink
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(100, 100); // Thiết lập kích thước của PictureBox
                pictureBox.Location = new Point(25, 10); // Thiết lập vị trí của PictureBox trong Panel

                // Kiểm tra và tải ảnh từ URL
                if (!string.IsNullOrEmpty(drink.ImageURL))
                {
                    try
                    {
                        pictureBox.Load(drink.ImageURL);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Tạo một Button để hiển thị thông tin của drink
                Button btn = new Button();
                btn.Size = new Size(130, 30); // Thiết lập kích thước của Button
                btn.Location = new Point(10, 115); // Thiết lập vị trí của Button trong Panel
                btn.BackColor = Color.LightSalmon; // Thiết lập màu sắc của Button
                btn.Text = $"ID: {drink.ID}\nName: {drink.Name}\nPrice: {drink.Price}";

                // Gán sự kiện Click cho Button (nếu cần)
                // btn.Click += (s, e) => { /* Code xử lý khi Button được nhấn */ };

                // Thêm PictureBox và Button vào Panel
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(btn);

                // Thêm Panel vào drinksFlowLayoutPanel
                drinksFlowLayoutPanel.Controls.Add(panel);
            }
        }



    }


}


