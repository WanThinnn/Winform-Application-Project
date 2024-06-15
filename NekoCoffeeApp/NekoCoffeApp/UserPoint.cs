using Aspose.Email.Calendar.Recurrences;
using Aspose.Email.Clients.ActiveSync.TransportLayer;
using Aspose.Email.PersonalInfo;
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
    public partial class UserPoint : UserControl
    {

        private static UserPoint _instance;
        public static UserPoint Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserPoint();
                return _instance;
            }
        }
        public UserPoint()
        {
            InitializeComponent();
        }

        private void UserPoint_Load(object sender, EventArgs e)
        {
            if (GlobalVars.CurrentUser == null)
            {
                MessageBox.Show("Bạn cần đăng nhập để tiếp tục!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbFullname.Text = GlobalVars.CurrentUser.Fullname;
                txtPoint.Text = GlobalVars.CurrentUser.Point.ToString();
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
