using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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

        IFirebaseClient client;

        private IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        public UserMenu()
        {
            InitializeComponent();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
                if (client == null)
                {
                    MessageBox.Show("Không thể kết nối đến Firebase.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LoadDrinks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối Firebase: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadDrinks()
        {
            try
            {
                var response = await client.GetAsync("/Drinks");

                // Check if response or response.Body is null
                if (response == null || response.Body == null)
                {
                    MessageBox.Show("Không có dữ liệu từ Firebase.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string jsonData = response.Body;

                // Check if jsonData is a JSON array
                List<NekoDrink> drinksList;

                if (jsonData.TrimStart().StartsWith("["))
                {
                    // If it's a JSON array, deserialize it as a list
                    drinksList = JsonConvert.DeserializeObject<List<NekoDrink>>(jsonData);
                }
                else
                {
                    // If it's not a JSON array, deserialize it as a dictionary
                    var drinksDict = JsonConvert.DeserializeObject<IDictionary<string, NekoDrink>>(jsonData);
                    drinksList = drinksDict?.Values.ToList();
                }

                // Check if drinksList is null or empty
                if (drinksList == null || !drinksList.Any())
                {
                    MessageBox.Show("Không tìm thấy dữ liệu đồ uống.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Clear the previous controls
                drinksFlowLayoutPanel.Controls.Clear();

                foreach (var drink in drinksList)
                {
                    // Check if drink is null
                    if (drink == null)
                    {
                        continue;
                    }

                    // Create a new panel for each drink
                    Panel panel = new Panel();
                    panel.Size = new Size(200, 180); // Adjust the size of the Panel
                    //panel.BorderStyle = BorderStyle.FixedSingle;

                    // Create a PictureBox to display the drink's image
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(130, 110);
                    pictureBox.Location = new Point(35, 10); // Set the position of the PictureBox within the Panel
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    // Check and load the image from URL
                    if (!string.IsNullOrEmpty(drink.ImageURL))
                    {
                        try
                        {
                            pictureBox.Load(drink.ImageURL);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    // Create a Label to display the drink's name
                    Label nameLabel = new Label();
                    nameLabel.Text = drink.Name ?? "Unknown";
                    nameLabel.Location = new Point(10, 130); // Set the position of the Label below the PictureBox
                    nameLabel.AutoSize = true;
                    nameLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                    // Create a Label to display the drink's price
                    Label priceLabel = new Label();
                    priceLabel.Text = $"{drink.Price} VND";
                    priceLabel.Location = new Point(10, 150); // Set the position of the Label below the name
                    priceLabel.AutoSize = true;
                    priceLabel.Font = new Font("Segoe UI", 8, FontStyle.Bold);

                    // Create a NumericUpDown for quantity selection
                    NumericUpDown numericUpDown = new NumericUpDown();
                    numericUpDown.Size = new Size(50, 20);
                    numericUpDown.Location = new Point(145, 150); // Set the position of the NumericUpDown within the Panel
                    numericUpDown.Minimum = 1;
                    numericUpDown.Maximum = 100;

                    // Create a Button to add the drink to cart and table detail
                    Button btn = new Button();
                    btn.Size = new Size(50, 28);
                    btn.Location = new Point(135, 120); // Set the position of the Button within the Panel
                    btn.BackColor = Color.LightSalmon;
                    btn.Text = "Mua";

                    btn.Click += (s, e) =>
                    {
                        int quantity = (int)numericUpDown.Value;
                        int price = Convert.ToInt32(drink.Price);
                        AddToCartAndTableDetail(drink.Name, quantity, price);
                    };

                    // Add PictureBox, Labels, NumericUpDown, and Button to the Panel
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(nameLabel);
                    panel.Controls.Add(priceLabel);
                    panel.Controls.Add(numericUpDown);
                    panel.Controls.Add(btn);

                    // Add the Panel to drinksFlowLayoutPanel
                    drinksFlowLayoutPanel.Controls.Add(panel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách đồ uống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddToCartAndTableDetail(string drinkName, int quantity, int price)
        {
            // Add to UserCart
            UserCart.Instance.AddItemToCart(drinkName, quantity, price);

            // Add to TableDetail (if the form is open)
            var tableDetailForm = Application.OpenForms.OfType<TableDetail>().FirstOrDefault();
            if (tableDetailForm != null)
            {
                tableDetailForm.AddItemToTableDetail(drinkName, quantity, price);
            }
        }
    }
}
