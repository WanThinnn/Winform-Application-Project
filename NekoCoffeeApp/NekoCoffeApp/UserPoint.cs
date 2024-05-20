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
    public partial class UserPoint : UserControl
    {

        private static UserPoint _instance;
        public static UserPoint Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserPoint();
                return _instance;
            }
        }
        public UserPoint()
        {
            InitializeComponent();
        }
    }
}
