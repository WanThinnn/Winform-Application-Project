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
    public partial class AdminCustomer : UserControl
    {
        public AdminCustomer()
        {
            InitializeComponent();
        }

        private static AdminCustomer _instance;
        public static AdminCustomer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminCustomer();
                return _instance;
            }
        }

        private void AdminCheckCustomer_Click(object sender, EventArgs e)
        {

        }

        private void AdminAddCustomer_Click(object sender, EventArgs e)
        {

        }

        private void AdminCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
