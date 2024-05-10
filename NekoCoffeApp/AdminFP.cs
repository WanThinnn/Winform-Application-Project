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
        private System.Windows.Forms.Panel panel; 
        private BunifuButton adminMenuBtnInstance;

        public AdminFP()
        {
            InitializeComponent();
            panel = new System.Windows.Forms.Panel(); // Khởi tạo biến panel
            panel.Dock = DockStyle.Fill;
            Controls.Add(panel); // Thêm panel vào các điều khiển của form
            adminMenuBtnInstance = new BunifuButton(); // Khởi tạo biến để lưu trữ phiên bản của BunifuButton.


        }
        private void AdminMenuBtn_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu panel chưa chứa adminMenuBtn thì thêm vào
            if (!panel.Controls.Contains(adminMenuBtnInstance))
            {
                adminMenuBtnInstance.Dock = DockStyle.Fill;
                panel.Controls.Add(adminMenuBtnInstance);
                adminMenuBtnInstance.BringToFront();
            }
            else
            {
                // Nếu panel đã chứa adminMenuBtn, đưa nó lên trước
                adminMenuBtnInstance.BringToFront();
            }
        }
    }
}
