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
            try
            {
                var response = await tbl.GetAsync("/Drinks");

                // Check if response or response.Body is null
                if (response == null || response.Body == null)
                {
                    MessageBox.Show("No data available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("No data available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    panel.BorderStyle = BorderStyle.None;

                    // Create a PictureBox to display the drink's image
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(130, 110);
                    pictureBox.Location = new Point(50, 10); // Set the position of the PictureBox within the Panel
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
                    nameLabel.Location = new Point(50, 120); // Set the position of the Label below the PictureBox
                    nameLabel.AutoSize = true;
                    nameLabel.Font = new Font("UTM Avo", 10, FontStyle.Bold);


                    // Create a Label to display the drink's price
                    Label priceLabel = new Label();
                    priceLabel.Text = drink.Price.ToString();
                    priceLabel.Location = new Point(50, 140); // Set the position of the Label below the name
                    priceLabel.AutoSize = true;
                    priceLabel.Font = new Font("UTM Avo", 8, FontStyle.Bold);

                    // Create a Button to display the drink's information
                    Button btn = new Button();
                    btn.Size = new Size(60, 30);
                    btn.Location = new Point(120, 135); // Set the position of the Button within the Panel
                    btn.BackColor = Color.LightSalmon;
                    btn.Text = "BUY";

                    // Add event handler for Button click (if needed)
                    // btn.Click += (s, e) => { /* Code to handle button click */ };

                    // Add PictureBox, Labels, and Button to the Panel
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(nameLabel);
                    panel.Controls.Add(priceLabel);
                    panel.Controls.Add(btn);

                    // Add the Panel to drinksFlowLayoutPanel
                    drinksFlowLayoutPanel.Controls.Add(panel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {

        }
    }


}


