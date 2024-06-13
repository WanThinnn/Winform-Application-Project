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
    public partial class UserDiscount : UserControl
    {
        private static UserDiscount _instance;
        public static UserDiscount Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserDiscount();
                return _instance;
            }
        }
        public UserDiscount()
        {
            InitializeComponent();
        }
        IFirebaseClient client;

        private IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        private void AdminItems_Load(object sender, EventArgs e)
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
                    Loaditems();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối Firebase: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void Loaditems()
        {
            try
            {
                var response = await client.GetAsync("/Items");

                // Check if response or response.Body is null
                if (response == null || response.Body == null)
                {
                    MessageBox.Show("Không có dữ liệu từ Firebase.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string jsonData = response.Body;

                // Check if jsonData is a JSON array
                List<NekoItem> itemsList;

                if (jsonData.TrimStart().StartsWith("["))
                {
                    // If it's a JSON array, deserialize it as a list
                    itemsList = JsonConvert.DeserializeObject<List<NekoItem>>(jsonData);
                }
                else
                {
                    // If it's not a JSON array, deserialize it as a dictionary
                    var itemsDict = JsonConvert.DeserializeObject<IDictionary<string, NekoItem>>(jsonData);
                    itemsList = itemsDict?.Values.ToList();
                }

                // Check if itemsList is null or empty
                if (itemsList == null || !itemsList.Any())
                {
                    MessageBox.Show("Không tìm thấy dữ liệu đồ uống.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Clear the previous controls
                itemsFlowLayoutPanel.Controls.Clear();

                foreach (var item in itemsList)
                {
                    // Check if item is null
                    if (item == null)
                    {
                        continue;
                    }

                    // Create a new panel for each item
                    Panel panel = new Panel();
                    panel.Size = new Size(200, 200); // Adjust the size of the Panel
                    //panel.BorderStyle = BorderStyle.FixedSingle;

                    // Create a PictureBox to display the item's image
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(130, 110);
                    pictureBox.Location = new Point(35, 10); // Set the position of the PictureBox within the Panel
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    // Check and load the image from URL
                    if (!string.IsNullOrEmpty(item.ImageURL))
                    {
                        try
                        {
                            pictureBox.Load(item.ImageURL);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    // Create a Label to display the item's name
                    Label nameLabel = new Label();
                    nameLabel.Text = item.Name ?? "Unknown";
                    nameLabel.Location = new Point(10, 130); // Set the position of the Label below the PictureBox
                    nameLabel.AutoSize = true;
                    nameLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                    // Create a Label to display the item's price
                    Label priceLabel = new Label();
                    priceLabel.Text = $"{item.Price} VND";
                    priceLabel.Location = new Point(10, 150); // Set the position of the Label below the name
                    priceLabel.AutoSize = true;
                    priceLabel.Font = new Font("Segoe UI", 8, FontStyle.Bold);

                    // Create a Label to display the item's price
                    Label pointLabel = new Label();
                    pointLabel.Text = $"{item.Point} Điểm";
                    pointLabel.Location = new Point(10, 165); // Set the position of the Label below the name
                    pointLabel.AutoSize = true;
                    pointLabel.Font = new Font("Segoe UI", 8, FontStyle.Bold);

                    // Create a NumericUpDown for quantity selection
                    //NumericUpDown numericUpDown = new NumericUpDown();
                    //numericUpDown.Size = new Size(50, 20);
                    //numericUpDown.Location = new Point(145, 155); // Set the position of the NumericUpDown within the Panel
                    //numericUpDown.Minimum = 1;
                    //numericUpDown.Maximum = 100;

                    // Create a Button to add the item to cart and table detail
                    Button btn = new Button();
                    btn.Size = new Size(50, 28);
                    btn.Location = new Point(135, 150); // Set the position of the Button within the Panel
                    btn.BackColor = Color.LightSalmon;
                    btn.Text = "Nhận";

                    btn.Click += (s, e) =>
                    {
                        UserGetItem frm = new UserGetItem(item);
                        frm.Show();
                    };

                    // Add PictureBox, Labels, NumericUpDown, and Button to the Panel
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(nameLabel);
                    panel.Controls.Add(priceLabel);
                    panel.Controls.Add(pointLabel);
                    //panel.Controls.Add(numericUpDown);
                    panel.Controls.Add(btn);

                    // Add the Panel to itemsFlowLayoutPanel
                    itemsFlowLayoutPanel.Controls.Add(panel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách đồ uống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
