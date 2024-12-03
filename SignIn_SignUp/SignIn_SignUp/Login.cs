using Login_SignUp;
using System.Runtime.Intrinsics.X86;

namespace SignIn_SignUp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp tab = new SignUp();
            tab.Show();
            tab.ShowDialog();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPass tab_2 = new ForgotPass();
            this.Hide();
            tab_2.Show();
            tab_2.ShowDialog();
        }
    }
}
