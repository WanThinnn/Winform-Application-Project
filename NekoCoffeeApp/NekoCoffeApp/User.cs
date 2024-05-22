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

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanelGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminUserImg_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {

        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {

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

        private void btnOrder_Click(object sender, EventArgs e)
        {

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

        }
    }
}
