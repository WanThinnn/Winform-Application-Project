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
    public partial class edit_Order : Form
    {
        public edit_Order()
        {
            InitializeComponent();
        }
        string MasterUserName;
        private void adminDrink1_Load(object sender, EventArgs e)
        {
            
        }

        private void adminDrink1_Load_1(object sender, EventArgs e)
        {

        }

        private void edit_Order_Load(object sender, EventArgs e)
        {
            string masterUserName = this.MasterUserName; // Assuming MasterUserName is available in this context

            AdminDrink adDrink = AdminDrink.Instance();

            if (!AdminMainPanel.Controls.Contains(adDrink))
            {
                AdminMainPanel.Controls.Add(adDrink);
                adDrink.Dock = DockStyle.Fill;
                adDrink.BringToFront();
            }
            else
            {
                adDrink.BringToFront();
            }
        }
        
    }
}
