using Firebase.Storage;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class UserAccount : UserControl
    {
        private static UserAccount _instance;
        public static UserAccount Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserAccount();
                return _instance;
            }
        }

        public UserAccount()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        FirebaseStorage firebaseStorage;

        private void UserAccount_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
                firebaseStorage = new FirebaseStorage("neko-coffe-database.appspot.com");
            }
            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (GlobalVars.CurrentUser == null)
            {
                MessageBox.Show("Bạn cần đăng nhập để tiếp tục!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbFullname.Text = GlobalVars.CurrentUser.Fullname;
                lbBirthday.Text = GlobalVars.CurrentUser.Birthday;
                lbDay.Text = GlobalVars.CurrentUser.RegistrationDate.ToString("dd/MM/yyyy");
                lbEmail.Text = GlobalVars.CurrentUser.Email;
                lbGender.Text = GlobalVars.CurrentUser.Gender;
                lbPhone.Text = GlobalVars.CurrentUser.PhoneNumber;
                lbUsername.Text = GlobalVars.CurrentUser.Username;
                try
                {
                    AvatarPictureBox.Load(GlobalVars.CurrentUser.Avatar);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        string selectedImagePath;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image File(*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = ofd.FileName;
                Image img = new Bitmap(ofd.FileName);
                AvatarPictureBox.Image = img.GetThumbnailImage(223, 223, null, new IntPtr());
                AvatarPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedImagePath == null)
            {
                MessageBox.Show("Bạn chưa chọn ảnh. Vui lòng ấn vào biểu tượng chỉnh sửa để chọn ảnh trước khi cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Upload the image to Firebase Storage
                MemoryStream ms = new MemoryStream();
                AvatarPictureBox.Image.Save(ms, ImageFormat.Jpeg);
                ms.Position = 0;

                var uploadTask = firebaseStorage
                    .Child("Users")
                    .Child(GlobalVars.CurrentUser.Username + ".jpg")
                    .PutAsync(ms);

                var downloadUrl = await uploadTask;

                // Update the user's Avatar URL
                GlobalVars.CurrentUser.Avatar = downloadUrl;

                // Save the updated user information to Firebase Realtime Database
                SetResponse response = client.Set($"Users/{GlobalVars.CurrentUser.Username}", GlobalVars.CurrentUser);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Đã cập nhật ảnh đại diện thành công! Vui lòng đăng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật ảnh đại diện thất bại. Vui lòng thử lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
