using Bunifu.Framework.UI;
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
    public partial class UserRating : UserControl
    {
        private static UserRating _instance;
        public static UserRating Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserRating();
                return _instance;
            }
        }
        public UserRating()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient tbl;

        private void UserRating_Load(object sender, EventArgs e)
        {
            try
            {
                tbl = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadRates();
        }

        async void LoadRates()
        {
            try
            {
                var response = await tbl.GetAsync("/Ratings");

                // Check if response or response.Body is null
                if (response == null || response.Body == null)
                {
                    MessageBox.Show("No data available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string jsonData = response.Body;

                // Check if jsonData is a JSON array
                List<NekoRating> ratingsList;

                if (jsonData.TrimStart().StartsWith("["))
                {
                    // If it's a JSON array, deserialize it as a list
                    ratingsList = JsonConvert.DeserializeObject<List<NekoRating>>(jsonData);
                }
                else
                {
                    // If it's not a JSON array, deserialize it as a dictionary
                    var ratingsDict = JsonConvert.DeserializeObject<IDictionary<string, NekoRating>>(jsonData);
                    ratingsList = ratingsDict?.Values.ToList();
                }

                // Check if ratingsList is null or empty
                if (ratingsList == null || !ratingsList.Any())
                {
                    MessageBox.Show("No data available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calculate the average star rating and the number of ratings
                double averageRating = ratingsList.Average(r => r.Star);
                int numberOfRatings = ratingsList.Count;

                // Update lbPoint and lbPeople
                lbPoint.Text = $"{averageRating:F1}/5"; // Format to 2 decimal places
                lbPeople.Text = $"{numberOfRatings} nhận xét";
                ratingStars.Value = (int)(averageRating);

                // Clear the previous controls
                commentsFlowLayoutPanel.Controls.Clear();

                foreach (var rating in ratingsList)
                {
                    // Check if rating is null
                    if (rating == null)
                    {
                        continue;
                    }

                    // Create a new Button for each rating
                    Button ratingButton = new Button();
                    ratingButton.Size = new Size(650, 100); // Adjust the size of the Button
                    ratingButton.Location = new Point(10, 10);
                    ratingButton.BackColor = Color.White;
                    ratingButton.FlatStyle = FlatStyle.Flat;
                    ratingButton.FlatAppearance.BorderSize = 0;

                    // Create a Label to display the rating's name
                    Label nameLabel = new Label();
                    nameLabel.Text = rating.Fullname ?? "Unknown";
                    nameLabel.Location = new Point(10, 10); // Set the position of the Label inside the Button
                    nameLabel.AutoSize = true;
                    nameLabel.Font = new Font("UTM Avo", 10, FontStyle.Bold);

                    // Create a BunifuRating to display the rating's star
                    BunifuRating pointLabel = new BunifuRating();
                    pointLabel.Value = rating.Star;
                    pointLabel.Location = new Point(10, 40); // Set the position of the BunifuRating inside the Button
                    pointLabel.Size = new Size(80, 4); // Điều chỉnh kích thước của BunifuRating
                    pointLabel.AutoSize = true;
                    pointLabel.Enabled = false;


                    // Create a Label to display the rating's comment
                    Label commentLabel = new Label();
                    commentLabel.Text = rating.Comment ?? "No comment";
                    commentLabel.Location = new Point(10, 70); // Set the position of the Label inside the Button
                    commentLabel.AutoSize = true;
                    commentLabel.Font = new Font("UTM Avo", 8, FontStyle.Italic);

                    // Add controls to the Button
                    ratingButton.Controls.Add(nameLabel);
                    ratingButton.Controls.Add(pointLabel);
                    ratingButton.Controls.Add(commentLabel);

                    // Add the Button to the FlowLayoutPanel
                    commentsFlowLayoutPanel.Controls.Add(ratingButton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminOrderTableBtn_Click(object sender, EventArgs e)
        {
            RatingStar rate = new RatingStar();
            rate.ShowDialog();
            btnSend_Click(sender, e);   
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            LoadRates();
        }
    }
}
