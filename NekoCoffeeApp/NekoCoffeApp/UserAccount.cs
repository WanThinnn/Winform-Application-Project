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

        private string cpBirthday, cpPhone;
        public UserAccount()
        {
            InitializeComponent();
            cpBirthday = lbBirthday.Text;
            cpPhone = lbPhone.Text;
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
            lbBirthday.Enabled = false;
            lbPhone.Enabled = false;
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


        private void editBirthday_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbBirthday.Enabled = true;
        }

        private void editPhone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbPhone.Enabled = true;
        }

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
            if (cpBirthday == lbBirthday.Text && cpPhone == lbPhone.Text && selectedImagePath == null)
            {
                MessageBox.Show("Không có thay đổi nào để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (selectedImagePath != null)
                {
                    // Upload the image to Firebase Storage
                    MemoryStream ms = new MemoryStream();
                    AvatarPictureBox.Image.Save(ms, ImageFormat.Jpeg);
                    ms.Position = 0;

                    var uploadTask = firebaseStorage
                        .Child("Users")
                        .Child(lbUsername.Text + ".jpg")
                        .PutAsync(ms);

                    var downloadUrl = await uploadTask;

                    // Update the user's Avatar URL
                    GlobalVars.CurrentUser.Avatar = downloadUrl;
                }

                // Update user information
                GlobalVars.CurrentUser.Birthday = lbBirthday.Text;
                GlobalVars.CurrentUser.PhoneNumber = lbPhone.Text;

                // Save the updated user information to Firebase Realtime Database
                SetResponse response = await client.SetAsync($"Users/{GlobalVars.CurrentUser.Username}", GlobalVars.CurrentUser);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Cập nhật thông tin thành công! Vui lòng đăng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, add logic to log the user out and prompt for re-login
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thất bại. Vui lòng thử lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
