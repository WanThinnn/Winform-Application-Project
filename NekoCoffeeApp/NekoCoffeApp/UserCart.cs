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
    public partial class UserCart : UserControl
    {
        private static UserCart _instance;
        public static UserCart Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserCart();
                return _instance;
            }
        }

        public UserCart()
        {
            InitializeComponent();
        }

        private void UserCart_Load(object sender, EventArgs e)
        {

        }
    }
}
