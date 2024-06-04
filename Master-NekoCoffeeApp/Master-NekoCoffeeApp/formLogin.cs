using BCrypt.Net;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;


        private void formLogin_Load(object sender, EventArgs e)
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txUser.Text) ||
               string.IsNullOrWhiteSpace(txPass.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FirebaseResponse res = client.Get(@"Users/" + txUser.Text);
            MasterUser ResUser = res.ResultAs<MasterUser>();
            string HashPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(txPass.Text, hashType: HashType.SHA384);


            MasterUser CurUser = new MasterUser()
            {
                Username = txUser.Text,
                Password = txPass.Text,
            };

            if (MasterUser.IsEqual(ResUser, CurUser) == true)
            {
                Home home = new Home(ResUser.Fullname, ResUser.Username);
                //MessageBox.Show("Đăng nhập thành công!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                home.ShowDialog();
                this.Show(); // Hiển thị lại form đăng nhập sau khi form chính đóng


            }
            else
            {
                MasterUser.ShowError();
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            BeforeSignUp frm = new BeforeSignUp();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void lkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPwd res = new ForgotPwd();
            this.Hide();
            res.ShowDialog();
            this.Show();
        }

        private void formLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void txPass_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txPass.Text))
            {
                this.txPass.PlaceholderText = "Password";
                this.txPass.PasswordChar = '\0'; // Loại bỏ ký tự password
            }
            else
            {
                this.txPass.PlaceholderText = "";
                this.txPass.PasswordChar = '●';
            }
        }
    }
}
