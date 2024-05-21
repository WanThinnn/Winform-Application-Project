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
    public partial class AdminAdjust : UserControl
    {
        public AdminAdjust()
        {
            InitializeComponent();
        }

        private static AdminAdjust _instance;
        public static AdminAdjust Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminAdjust();
                return _instance;
            }
        }

        private void AdminAdjust_Load(object sender, EventArgs e)
        {

        }

        private void AdminAdjustCustomer_Click(object sender, EventArgs e)
        {

        }

        private void AdminAdjustProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
