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
    public partial class UserDiscount : UserControl
    {
        private static UserDiscount _instance;
        public static UserDiscount Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserDiscount();
                return _instance;
            }
        }
        public UserDiscount()
        {
            InitializeComponent();
        }
    }
}
