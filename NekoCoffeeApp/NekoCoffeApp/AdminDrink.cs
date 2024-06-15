using Aspose.Email.Clients.Exchange.WebService.Schema_2016;
using Aspose.Email.PersonalInfo;
using BCrypt.Net;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Firebase.Storage;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.LinkLabel;


namespace UI
{
    public partial class AdminDrink : UserControl
    {
      
        public AdminDrink()
        {
            InitializeComponent();
            
        }
        private static AdminDrink _instance;
        public static AdminDrink Instance()
        {
            if (_instance == null)
            {
                _instance = new AdminDrink();
            }
            return _instance;

        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient drk;
        FirebaseStorage firebaseStorage;

        private void AdminDrink_Load_1(object sender, EventArgs e)
        {
            try
            {
                drk = new FireSharp.FirebaseClient(ifc);
                firebaseStorage = new FirebaseStorage("neko-coffe-database.appspot.com");
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            viewData();
        }

        private async void AdminAddDrink_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AdminFillDrinkID.Text) ||
                string.IsNullOrWhiteSpace(AdminFillDrinkType.Text) ||
                string.IsNullOrWhiteSpace(AdminFillDrinkPrice.Text) ||
                string.IsNullOrWhiteSpace(AdminFillDrinkAvailable.Text) ||
                string.IsNullOrWhiteSpace(AdminFillDrinkName.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = drk.Get($"Drinks/" + AdminFillDrinkID.Text);
            NekoDrink ResDrink = res.ResultAs<NekoDrink>();

            NekoDrink CurDrink = new NekoDrink()
            {
                Name = AdminFillDrinkID.Text
            };

            if (NekoDrink.Search(ResDrink, CurDrink))
            {
                NekoDrink.ShowError_2();
                return;
            }

            // Thêm ảnh
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, ImageFormat.Jpeg);
            ms.Position = 0;

            // Tải ảnh lên Firebase Storage
            var uploadTask = firebaseStorage
                .Child("Drinks")
                .Child(AdminFillDrinkID.Text + ".jpg")
                .PutAsync(ms);

            // Lấy URL của ảnh
            var imageUrl = await uploadTask;

            NekoDrink drink = new NekoDrink()
            {
                ID = AdminFillDrinkID.Text,
                Name = AdminFillDrinkName.Text,
                Available = AdminFillDrinkAvailable.Text,
                Price = AdminFillDrinkPrice.Text,
                Type = AdminFillDrinkType.Text,
                ImageURL = imageUrl
            };

            SetResponse set = drk.Set($"Drinks/" + AdminFillDrinkID.Text, drink);

            if (set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                AdminFillDrinkID.Clear();
                AdminFillDrinkName.Clear();
                AdminFillDrinkAvailable.Text = "";
                AdminFillDrinkPrice.Clear();
                AdminFillDrinkSearch.Clear();
                AdminFillDrinkType.Clear();
                pictureBox.Image = null;
                MessageBox.Show($"Thêm thành công nước {AdminFillDrinkID.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewData();
            }
        }

        async void viewData()
        {
            try
            {
                var data = await drk.GetAsync($"Drinks/");

                // Check if data or data.Body is null
                if (data == null || data.Body == null)
                {
                    AdminViewAllYourDrinks.DataSource = null;
                    return;
                }

                string jsonData = data.Body;

                // Kiểm tra xem jsonData có phải là mảng JSON không
                if (jsonData.TrimStart().StartsWith("["))
                {
                    // Nếu là mảng JSON, xử lý nó như một danh sách
                    var mListArray = JsonConvert.DeserializeObject<List<NekoDrink>>(jsonData);

                    // Check if mListArray is null or empty
                    if (mListArray == null || !mListArray.Any())
                    {
                        AdminViewAllYourDrinks.DataSource = null;
                        return;
                    }

                    AdminViewAllYourDrinks.DataSource = mListArray;
                }
                else
                {
                    // Nếu không phải mảng JSON, xử lý nó như một đối tượng JSON
                    var mList = JsonConvert.DeserializeObject<IDictionary<string, NekoDrink>>(jsonData);

                    // Check if mList is null or empty
                    if (mList == null || !mList.Any())
                    {
                        AdminViewAllYourDrinks.DataSource = null;
                        return;
                    }

                    var listNumber = mList.Values.ToList();
                    AdminViewAllYourDrinks.DataSource = listNumber;
                }
            }
            catch (Exception ex)
            {
                //
                //MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void AdminDeleteDrink_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AdminFillDrinkID.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = drk.Get($"Drinks/" + AdminFillDrinkID.Text);
            NekoDrink ResDrink = res.ResultAs<NekoDrink>();

            NekoDrink CurDrink = new NekoDrink()
            {
                ID = AdminFillDrinkID.Text
            };

            if (!NekoDrink.IsExist(ResDrink, CurDrink))
            {
                NekoDrink.ShowError_3();
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá nước?", "Xác nhận xoá", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                // Xóa ảnh từ Firebase Storage
                try
                {
                    var storage = new FirebaseStorage("neko-coffe-database.appspot.com");
                    await storage.Child("Drinks").Child(AdminFillDrinkID.Text + ".jpeg").DeleteAsync();
                    var imageUrl = ResDrink.ImageURL; // Assuming the ImageURL is stored in ResDrink
                    var fileName = new Uri(imageUrl).Segments.Last();

                    // Remove the leading '/' from fileName if it exists
                    if (fileName.StartsWith("/"))
                    {
                        fileName = fileName.Substring(1);
                    }

                    var imageReference = firebaseStorage.Child(fileName);

                    await imageReference.DeleteAsync();

                    MessageBox.Show("Ảnh đã được xoá thành công từ Firebase Storage", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show($"Lỗi khi xoá ảnh từ Firebase Storage: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Xóa dữ liệu từ Firebase Database
                var delete = drk.Delete($"Drinks/" + AdminFillDrinkID.Text);
                if (delete.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"Xoá nước {AdminFillDrinkID.Text} thành công!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminFillDrinkID.Clear();
                    AdminFillDrinkName.Clear();
                    AdminFillDrinkAvailable.Items.Clear();
                    AdminFillDrinkPrice.Clear();
                    AdminFillDrinkSearch.Clear();
                    AdminFillDrinkType.Clear();
                    pictureBox.Image = null;
                }
                else
                {
                    MessageBox.Show($"Lỗi khi xoá nước: {delete.StatusCode}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
            viewData();
        }




        private void AdminUpdateDrink_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = drk.Get($"Drinks/" + AdminFillDrinkID.Text);
            NekoDrink ResDrink = res.ResultAs<NekoDrink>();

            NekoDrink CurDrink = new NekoDrink()
            {
                ID = AdminFillDrinkID.Text
            };

            if (!NekoDrink.IsExist(ResDrink, CurDrink))
            {
                NekoDrink.ShowError_3();
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                NekoDrink drink = new NekoDrink()
                {
                    ID = AdminFillDrinkID.Text,
                    Name = AdminFillDrinkName.Text,
                    Available = AdminFillDrinkAvailable.Text,
                    Price = AdminFillDrinkPrice.Text,
                    Type = AdminFillDrinkType.Text,
                    ImageURL = ResDrink.ImageURL,
                };

                FirebaseResponse update = drk.Update($"Drinks/" + AdminFillDrinkID.Text, drink);

                if (update.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    AdminFillDrinkID.Clear();
                    AdminFillDrinkName.Clear();
                    AdminFillDrinkAvailable.Text = "";
                    AdminFillDrinkPrice.Clear();
                    AdminFillDrinkSearch.Clear();
                    AdminFillDrinkType.Clear();
                    pictureBox.Image = null;
                    MessageBox.Show($"Sửa thành công nước {AdminFillDrinkID.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    viewData();
                }
                else { return; }
                viewData();
            }
        }

        private void AdminCheckDrink_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AdminFillDrinkSearch.Text))
            {
                MessageBox.Show("Vui lòng điền mã nước", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = drk.Get($"Drinks/" + AdminFillDrinkSearch.Text);
            NekoDrink existingDrink = res.ResultAs<NekoDrink>();

            if (existingDrink == null)
            {
                MessageBox.Show("Nước không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AdminFillDrinkID.Text = existingDrink.ID;
            AdminFillDrinkName.Text = existingDrink.Name;
            AdminFillDrinkType.Text = existingDrink.Type;
            AdminFillDrinkPrice.Text = existingDrink.Price;
            AdminFillDrinkAvailable.SelectedItem = existingDrink.Available;

            // Load ảnh vào PictureBox
            if (!string.IsNullOrEmpty(existingDrink.ImageURL))
            {
                try
                {
                    pictureBox.Load(existingDrink.ImageURL);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBox.Image = null; // Clear PictureBox if loading fails
                }
            }
            else
            {
                pictureBox.Image = null; // Clear PictureBox if no image URL
            }
        }


        private void AdminViewAllYourDrinks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void AdminFillDrinkPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image File(*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);
                pictureBox.Image = img.GetThumbnailImage(127, 141, null, new IntPtr());
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
