using FireSharp.Config;
using FireSharp.Interfaces;
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
        string Username;
        public Home(string Fullname, string Username)
        {
            InitializeComponent();
            this.Fullname = Fullname;
            this.Username = Username;
            this.linkLBHello.Text = $"Hello {Fullname}, wellcome back!";
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
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
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            User frm = new User(this.Username);
            frm.Show();

        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            Cat frm = new Cat(this.Username);
            frm.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee frm = new Employee(this.Username);
            frm.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer frm = new Customer(this.Username);
            frm.Show();
        }
    }
}
