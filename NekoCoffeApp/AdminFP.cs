using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace UI
{
    public partial class AdminFP : Form
    {
        private System.Windows.Forms.Panel panel; // Khai báo biến panel
        private BunifuButton adminMenuButton;

        public AdminFP()
        {
            InitializeComponent();
            panel = new System.Windows.Forms.Panel(); // Khởi tạo biến panel
            panel.Dock = DockStyle.Fill;
            Controls.Add(panel); // Thêm panel vào các điều khiển của form

        }
        private void AdminMenuBtn_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(AdminMenuBtn.Instance))
            {
                panel.Controls.Add(AdminMenuBtn.Instance);
                AdminMenuBtn.Instance.Dock = DockStyle.Fill;
                AdminMenuBtn.Instance.BringToFront();
            }
            else
                AdminMenuBtn.Instance.BringToFront();
        }
    }
}
