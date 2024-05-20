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

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }
    }
}
