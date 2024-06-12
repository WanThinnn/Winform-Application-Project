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

        private void UserAccount_Load(object sender, EventArgs e)
        {
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
                    MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         

        }
    }
}
