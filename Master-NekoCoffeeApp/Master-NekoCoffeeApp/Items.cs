using Firebase.Storage;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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

namespace Master_NekoCoffeeApp
{
    public partial class Items : Form
    {
        string MasterUsername;
        public Items(string masterUsername)
        {
            InitializeComponent();
            MasterUsername = masterUsername;
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient item;
        FirebaseStorage firebaseStorage;
        async void viewData()
        {
            try
            {
                var data = await item.GetAsync($"Items/");

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
                    var mListArray = JsonConvert.DeserializeObject<List<NekoItem>>(jsonData);

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
                    var mList = JsonConvert.DeserializeObject<IDictionary<string, NekoItem>>(jsonData);

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

        private void Items_Load(object sender, EventArgs e)
        {
            try
            {
                item = new FireSharp.FirebaseClient(ifc);
                firebaseStorage = new FirebaseStorage("neko-coffe-database.appspot.com");
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            viewData();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbSearch.Text))
            {
                MessageBox.Show("Vui lòng điền mã sản phẩm", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = item.Get($"Items/" + txbSearch.Text);
            NekoItem existingDrink = res.ResultAs<NekoItem>();

            if (existingDrink == null)
            {
                MessageBox.Show("sản phẩm không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txbID.Text = existingDrink.ID;
            txbNameItem.Text = existingDrink.Name;
            dbType.Text = existingDrink.Type;
            txbPrice.Text = existingDrink.Price;
            dbStatus.SelectedItem = existingDrink.Available;

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

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbID.Text) ||
                string.IsNullOrWhiteSpace(dbType.Text) ||
                string.IsNullOrWhiteSpace(txbPrice.Text) ||
                string.IsNullOrWhiteSpace(dbStatus.Text) ||
                string.IsNullOrWhiteSpace(txbNameItem.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = item.Get($"Items/" + txbID.Text);
            NekoItem ResDrink = res.ResultAs<NekoItem>();

            NekoItem CurDrink = new NekoItem()
            {
                Name = txbID.Text
            };

            if (NekoItem.Search(ResDrink, CurDrink))
            {
                NekoItem.ShowError_2();
                return;
            }

            // Thêm ảnh
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, ImageFormat.Jpeg);
            ms.Position = 0;

            // Tải ảnh lên Firebase Storage
            var uploadTask = firebaseStorage
                .Child("Items")
                .Child(txbID.Text + ".jpg")
                .PutAsync(ms);

            // Lấy URL của ảnh
            var imageUrl = await uploadTask;

            NekoItem drink = new NekoItem()
            {
                ID = txbID.Text,
                Name = txbNameItem.Text,
                Available = dbStatus.Text,
                Price = txbPrice.Text,
                Type = dbType.Text,
                ImageURL = imageUrl
            };

            SetResponse set = item.Set($"Items/" + txbID.Text, drink);

            if (set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                txbID.Clear();
                txbNameItem.Clear();
                dbStatus.Items.Clear();
                txbPrice.Clear();
                txbSearch.Clear();
                dbType.Items.Clear();
                pictureBox.Image = null;
                MessageBox.Show($"Thêm thành công sản phẩm {txbID.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewData();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbID.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = item.Get($"Items/" + txbID.Text);
            NekoItem ResDrink = res.ResultAs<NekoItem>();

            NekoItem CurDrink = new NekoItem()
            {
                ID = txbID.Text
            };

            if (!NekoItem.IsExist(ResDrink, CurDrink))
            {
                NekoItem.ShowError_3();
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá sản phẩm?", "Xác nhận xoá", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                // Xóa ảnh từ Firebase Storage
                try
                {
                    var storage = new FirebaseStorage("neko-coffe-database.appspot.com");
                    await storage.Child("Items").Child(txbID.Text + ".jpeg").DeleteAsync();
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
                var delete = item.Delete($"Items/" + txbID.Text);
                if (delete.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"Xoá sản phẩm {txbID.Text} thành công!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbID.Clear();
                    txbNameItem.Clear();
                    dbStatus.Items.Clear();
                    txbPrice.Clear();
                    txbSearch.Clear();
                    dbType.Items.Clear();
                    pictureBox.Image = null;
                }
                else
                {
                    MessageBox.Show($"Lỗi khi xoá sản phẩm: {delete.StatusCode}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
            viewData();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = item.Get($"Items/" + txbID.Text);
            NekoItem ResDrink = res.ResultAs<NekoItem>();

            NekoItem CurDrink = new NekoItem()
            {
                ID = txbID.Text
            };

            if (!NekoItem.IsExist(ResDrink, CurDrink))
            {
                NekoItem.ShowError_3();
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                NekoItem drink = new NekoItem()
                {
                    ID = txbID.Text,
                    Name = txbNameItem.Text,
                    Available = dbStatus.Text,
                    Price = txbPrice.Text,
                    Type = dbType.Text
                };

                FirebaseResponse update = item.Update($"Items/" + txbID.Text, drink);

                if (update.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    txbID.Clear();
                    txbNameItem.Clear();
                    dbStatus.Items.Clear();
                    txbPrice.Clear();
                    txbSearch.Clear();
                    dbType.Items.Clear();
                    pictureBox.Image = null;

                    MessageBox.Show($"Sửa thành công sản phẩm {txbID.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { return; }
                viewData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txbID.Clear();
            txbID.ReadOnly = false;

            txbID.Clear();
            txbNameItem.Clear();
            dbStatus.Text = string.Empty;

            txbPrice.Clear();
            txbSearch.Clear();
            dbType.Items.Clear();



            txbID.BorderColorActive = Color.DodgerBlue;
            txbID.BorderColorHover = Color.FromArgb(105, 181, 255);
            txbID.BorderColorDisabled = Color.Silver;
            txbID.BorderColorIdle = Color.Black;


            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            viewData();
        }
    }
}
