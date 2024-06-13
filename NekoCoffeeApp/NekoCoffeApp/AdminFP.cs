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

            AdminEmployee adminEmployee = AdminEmployee.Instance();

            if (!AdminMainPanel.Controls.Contains(adminEmployee))
            {
                AdminMainPanel.Controls.Add(adminEmployee);
                adminEmployee.Dock = DockStyle.Fill;
                adminEmployee.BringToFront();
            }
            else
            {
                adminEmployee.BringToFront();
            }

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
            if (!AdminMainPanel.Controls.Contains(AdminAdjust.Instance))
            {
                AdminMainPanel.Controls.Add(AdminAdjust.Instance);
                AdminAdjust.Instance.Dock = DockStyle.Fill;
                AdminAdjust.Instance.BringToFront();
            }
            else
                AdminAdjust.Instance.BringToFront();
        }

        private void AdminReviewBtn_Click(object sender, EventArgs e)
        {
            if (!AdminMainPanel.Controls.Contains(AdminItems.Instance))
            {
                AdminMainPanel.Controls.Add(AdminItems.Instance);
                AdminItems.Instance.Dock = DockStyle.Fill;
                AdminItems.Instance.BringToFront();
            }
            else
                AdminItems.Instance.BringToFront();
        }

        public AdminFP()
        {
            InitializeComponent();
            //AdminEmployee.SwitchToAdminAdjustClicked += AdminEmployee_SwitchToAdminAdjustClicked;
     
        }

        private void AdminEmployee_SwitchToAdminAdjustClicked(object sender, EventArgs e)
        {
        
            this.Controls.Remove(AdminEmployee.Instance());

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
            if (!AdminMainPanel.Controls.Contains(AdminMenu.Instance))
            {
                AdminMainPanel.Controls.Add(AdminMenu.Instance);
                AdminMenu.Instance.Dock = DockStyle.Fill;
                AdminMenu.Instance.BringToFront();
            }
            else
                AdminMenu.Instance.BringToFront();
            if (GlobalVars.CurrentUser != null)
            {
                string fullName = GlobalVars.CurrentUser.Fullname;
                if (!string.IsNullOrWhiteSpace(fullName))
                {
                    // Tách chuỗi thành các từ và lấy từ cuối cùng
                    string[] nameParts = fullName.Split(' ');
                    string lastName = nameParts.Last();
                    AdminUser.Text = lastName;
                }
                else
                {
                    AdminUser.Text = string.Empty; // Xử lý trường hợp Fullname rỗng hoặc null
                }
                try
                {
                    AdminUserImg.Load(GlobalVars.CurrentUser.Avatar);
                }
                catch (Exception ex)
                {
                    /*MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AdminUserImg.Image = null; // Clear PictureBox if loading fails*/
                }
            }
        }

        private void AdminFP_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra xem người dùng có chắc chắn muốn đóng form không
            var result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy quá trình đóng form
            }
        }

        private void AdminUser_Click(object sender, EventArgs e)
        {
            if (!AdminMainPanel.Controls.Contains(UserAccount.Instance))
            {
                AdminMainPanel.Controls.Add(UserAccount.Instance);
                UserAccount.Instance.Dock = DockStyle.Fill;
                UserAccount.Instance.BringToFront();
            }
            else
                UserAccount.Instance.BringToFront();
        }
    }



}
