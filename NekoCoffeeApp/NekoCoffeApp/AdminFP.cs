using Bunifu.UI.WinForms.BunifuButton;
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
    public partial class AdminFP : Form
    {

        private void AdminMenuBtn_Click(object sender, EventArgs e)
        {
            if (!AdminMainPanel.Controls.Contains(AdminMenu.Instance))
            {
                AdminMainPanel.Controls.Add(AdminMenu.Instance);
                AdminMenu.Instance.Dock = DockStyle.Fill;
                AdminMenu.Instance.BringToFront();
            }
            else
                AdminMenu.Instance.BringToFront();
        }

        private void AdminOrderBtn_Click(object sender, EventArgs e)
        {
            if (!AdminMainPanel.Controls.Contains(AdminOrder.Instance))
            {
                AdminMainPanel.Controls.Add(AdminOrder.Instance);
                AdminOrder.Instance.Dock = DockStyle.Fill;
                AdminOrder.Instance.BringToFront();
            }
            else
                AdminOrder.Instance.BringToFront();
        }

        private void AdminEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (!AdminMainPanel.Controls.Contains(AdminEmployee.Instance))
            {
                AdminMainPanel.Controls.Add(AdminEmployee.Instance);
                AdminEmployee.Instance.Dock = DockStyle.Fill;
                AdminEmployee.Instance.BringToFront();
            }
            else
                AdminEmployee.Instance.BringToFront();
        }

        private void AdminFinancialBtn_Click(object sender, EventArgs e)
        {
            if (!AdminMainPanel.Controls.Contains(AdminFinancial.Instance))
            {
                AdminMainPanel.Controls.Add(AdminFinancial.Instance);
                AdminFinancial.Instance.Dock = DockStyle.Fill;
                AdminFinancial.Instance.BringToFront();
            }
            else
                AdminFinancial.Instance.BringToFront();
        }

        private void AdminCustomerBtn_Click(object sender, EventArgs e)
        {
            if (!AdminMainPanel.Controls.Contains(AdminCustomer.Instance))
            {
                AdminMainPanel.Controls.Add(AdminCustomer.Instance);
                AdminCustomer.Instance.Dock = DockStyle.Fill;
                AdminCustomer.Instance.BringToFront();
            }
            else
                AdminCustomer.Instance.BringToFront();
        }

        private void AdminReviewBtn_Click(object sender, EventArgs e)
        {
            if (!AdminMainPanel.Controls.Contains(AdminReview.Instance))
            {
                AdminMainPanel.Controls.Add(AdminReview.Instance);
                AdminReview.Instance.Dock = DockStyle.Fill;
                AdminReview.Instance.BringToFront();
            }
            else
                AdminReview.Instance.BringToFront();
        }

        public AdminFP()
        {
            InitializeComponent();
            //AdminEmployee.SwitchToAdminAdjustClicked += AdminEmployee_SwitchToAdminAdjustClicked;
        }

        private void AdminEmployee_SwitchToAdminAdjustClicked(object sender, EventArgs e)
        {
            this.Controls.Remove(AdminEmployee.Instance);

            AdminAdjust adminAdjustControl = new AdminAdjust();
            this.Controls.Add(AdminAdjust.Instance);
        }

        private void AdminMainPanel_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanelGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminCat1_Load(object sender, EventArgs e)
        {

        }

        private void AdminFP_Load(object sender, EventArgs e)
        {

        }
    }



}
