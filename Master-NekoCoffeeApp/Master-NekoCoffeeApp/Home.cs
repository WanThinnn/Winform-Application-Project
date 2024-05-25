using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_NekoCoffeeApp
{
    public partial class Home : Form
    {
        string Fullname;
        public Home(string Fullname)
        {
            InitializeComponent();
            this.Fullname = Fullname;
            this.linkLBHello.Text = $"Hello {Fullname}, wellcome back!";
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra xem người dùng có chắc chắn muốn đóng form không
            var result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy quá trình đóng form
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
