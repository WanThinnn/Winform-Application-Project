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
    public partial class AdminEmployee : UserControl
    {
        public AdminEmployee()
        {
            InitializeComponent();
        }

        private static AdminEmployee _instance;
        public static AdminEmployee Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminEmployee();
                return _instance;
            }
        }

        public event EventHandler SwitchToAdminAdjustClicked;

        private void AdminAdjustEmployee_Click(object sender, EventArgs e)
        {
            edit_Employee employee_Edit = new edit_Employee();
            employee_Edit.Show();
        }
    }
}

