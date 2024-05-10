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
    public partial class AdminMenu : UserControl
    {
            private static AdminMenu _instance;
            public static AdminMenu Instance
            {
                get
                {
                    if (_instance == null)
                        _instance = new AdminMenu();
                    return _instance;
                }
            }
            public AdminMenu()
            {
                InitializeComponent();
            }

            private void AdminMenu_Load (object sender, EventArgs e)
            {

            }
    }
}
