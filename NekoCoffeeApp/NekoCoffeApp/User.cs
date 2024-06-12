using BCrypt.Net;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Google.Apis.Oauth2.v2;
using Google.Apis.Services;
using Google.Apis.Oauth2.v2.Data;
namespace UI
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
            if (!panelUserControl.Controls.Contains(UserCart.Instance))
            {
                panelUserControl.Controls.Add(UserCart.Instance);
                UserCart.Instance.Dock = DockStyle.Fill;
                UserCart.Instance.BringToFront();
            }
            else
                UserCart.Instance.BringToFront();
        }


        private void AdminPanelGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminUserImg_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (!panelUserControl.Controls.Contains(UserAccount.Instance))
            {
                panelUserControl.Controls.Add(UserAccount.Instance);
                UserAccount.Instance.Dock = DockStyle.Fill;
                UserMenu.Instance.BringToFront();
            }
            else
                UserMenu.Instance.BringToFront();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            if (!panelUserControl.Controls.Contains(UserBooking.Instance))
            {
                panelUserControl.Controls.Add(UserBooking.Instance);
                UserBooking.Instance.Dock = DockStyle.Fill;
                UserBooking.Instance.BringToFront();
            }
            else
                UserPoint.Instance.BringToFront();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!panelUserControl.Controls.Contains(UserPoint.Instance))
            {
                panelUserControl.Controls.Add(UserPoint.Instance);
                UserPoint.Instance.Dock = DockStyle.Fill;
                UserPoint.Instance.BringToFront();
            }
            else
                UserPoint.Instance.BringToFront();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            if (!panelUserControl.Controls.Contains(UserDiscount.Instance))
            {
                panelUserControl.Controls.Add(UserDiscount.Instance);
                UserDiscount.Instance.Dock = DockStyle.Fill;
                UserDiscount.Instance.BringToFront();
            }
            else
                UserDiscount.Instance.BringToFront();
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
        
            if (!panelUserControl.Controls.Contains(UserMenu.Instance))
            {
                panelUserControl.Controls.Add(UserMenu.Instance);
                UserMenu.Instance.Dock = DockStyle.Fill;
                UserMenu.Instance.BringToFront();
            }
            else
                UserMenu.Instance.BringToFront();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (!panelUserControl.Controls.Contains(UserCart.Instance))
            {
                panelUserControl.Controls.Add(UserCart.Instance);
                UserCart.Instance.Dock = DockStyle.Fill;
                UserCart.Instance.BringToFront();
            }
            else
                UserCart.Instance.BringToFront();
        }

        private void User_Load(object sender, EventArgs e)
        {
            if (!panelUserControl.Controls.Contains(UserMenu.Instance))
            {
                panelUserControl.Controls.Add(UserMenu.Instance);
                UserMenu.Instance.Dock = DockStyle.Fill;
                UserMenu.Instance.BringToFront();
            }
            else
                UserMenu.Instance.BringToFront();

            if (GlobalVars.CurrentUser != null)
            {
                btnUser.Text = GlobalVars.CurrentUser.Username;
                try
                {
                    AdminUserImg.Load(GlobalVars.CurrentUser.Avatar);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AdminUserImg.Image = null; // Clear PictureBox if loading fails
                }
            }

        }
        private void LogoutGoogle()
        {
            string credPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "NekoGoogleLogin");
            string tokenFilePath = Path.Combine(credPath, "Google.Apis.Auth.OAuth2.Responses.TokenResponse-user");

            if (File.Exists(tokenFilePath))
            {
                try
                {
                    File.Delete(tokenFilePath); // Xóa file token chính xác
                    //MessageBox.Show($"Token file deleted from: {tokenFilePath}");
                    //MessageBox.Show("See you again!"); // Thông báo đăng xuất thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi trong quá trình đăng xuất: {ex.Message}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //MessageBox.Show("No login session found."); // Thông báo nếu file không tồn tại
                return;
            }
        }
        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogoutGoogle();
        }

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra xem người dùng có chắc chắn muốn đóng form không
            var result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy quá trình đóng form
            }
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            if (!panelUserControl.Controls.Contains(UserRating.Instance))
            {
                panelUserControl.Controls.Add(UserRating.Instance);
                UserRating.Instance.Dock = DockStyle.Fill;
                UserRating.Instance.BringToFront();
            }
            else
                UserRating.Instance.BringToFront();
        }
    }
}
