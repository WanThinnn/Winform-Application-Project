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
    public partial class UserRating : UserControl
    {
        private static UserRating _instance;
        public static UserRating Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserRating();
                return _instance;
            }
        }
        public UserRating()
        {
            InitializeComponent();
        }
    }
}
