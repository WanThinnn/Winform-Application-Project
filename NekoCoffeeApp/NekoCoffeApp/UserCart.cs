using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class UserCart : UserControl
    {
        private static UserCart _instance;
        public static UserCart Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserCart();
                return _instance;
            }
        }

        private IFirebaseClient client;

        private IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        private List<NekoCartItem> cartItems = new List<NekoCartItem>();
        private NekoTable selectedTable;

        public UserCart()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(ifc);
            if (client == null)
            {
                MessageBox.Show("Không thể kết nối đến Firebase.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserCart_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    client = new FireSharp.FirebaseClient(ifc);
            //    if (client == null)
            //    {
            //        MessageBox.Show("Không thể kết nối đến Firebase.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        RefreshCartUI();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Lỗi kết nối Firebase: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        public void AddItemToCart(string drinkName, int quantity, int price)
        {
            if (string.IsNullOrWhiteSpace(drinkName))
            {
                MessageBox.Show("Tên đồ uống không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (price <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingItem = cartItems.FirstOrDefault(item => item.DrinkName == drinkName);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
                existingItem.TotalPrice += price * quantity;
            }
            else
            {
                NekoCartItem newItem = new NekoCartItem
                {
                    DrinkName = drinkName,
                    Quantity = quantity,
                    Price = price,
                    TotalPrice = price * quantity
                };
                cartItems.Add(newItem);
            }

            RefreshCartUI();
        }

        private void RefreshCartUI()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var item in cartItems)
            {
                Panel panel = new Panel();
                panel.Size = new Size(200, 50);
                panel.BorderStyle = BorderStyle.FixedSingle ;

                Label nameLabel = new Label();
                nameLabel.Text = item.DrinkName;
                nameLabel.Location = new Point(10, 10);
                nameLabel.AutoSize = true;

                Label quantityLabel = new Label();
                quantityLabel.Text = "SL: " + item.Quantity.ToString();
                quantityLabel.Location = new Point(117, 10);
                quantityLabel.AutoSize = true;

                Label priceLabel = new Label();
                priceLabel.Text = "Price: " + item.TotalPrice.ToString() + " VND";
                priceLabel.Location = new Point(10, 30);
                priceLabel.AutoSize = true;

                panel.Controls.Add(nameLabel);
                panel.Controls.Add(quantityLabel);
                panel.Controls.Add(priceLabel);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            cartItems.Clear();
            RefreshCartUI();
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            if (selectedTable != null)
            {
                foreach (var item in cartItems)
                {
                    await AddItemToTableDetail(item.DrinkName, item.Quantity, item.Price);
                    
                }
            }
            cartItems.Clear();
            RefreshCartUI();
        }

        private async Task<bool> AddItemToTableDetail(string drinkName, int quantity, int price)
        {
            try
            {
                if (selectedTable == null)
                {
                    MessageBox.Show("Chưa chọn bàn để thêm mặt hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (client == null)
                {
                    MessageBox.Show("Không thể kết nối đến Firebase.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                var tableDetail = new NekoTableDetail
                {
                    Name = drinkName,
                    SL = quantity,
                    Total = price * quantity
                };

                FirebaseResponse response = await client.SetAsync($"TableDetails/{selectedTable.ID}/{drinkName}", tableDetail);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"Đã thêm mặt hàng {drinkName} vào Bàn {selectedTable.ID} thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Không thể thêm mặt hàng vào chi tiết bàn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm mặt hàng vào chi tiết bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
