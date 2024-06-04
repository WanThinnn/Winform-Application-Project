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
            var drinks  = JsonConvert.DeserializeObject<Dictionary<string, NekoDrink>>(response.Body);

            foreach (var drink in drinks.Values)
            {
                // Tạo một nút mới để hiển thị thông tin bảng
                Button btn = new Button();
                btn.Size = new Size(109, 109); // Thiết lập kích thước
                btn.BackColor = Color.LightSalmon; // Thiết lập màu sắc
                btn.Text = $"ID: {drink.ID}\nName: {drink.Name}\nPrice: {drink.Price}";

                // Gán sự kiện Click cho nút
                drinksFlowLayoutPanel.Controls.Add(btn);
                /*if {drink.Available ==}*/
            }
        }


    }

        
}
