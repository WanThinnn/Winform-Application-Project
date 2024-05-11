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
    public partial class AdminReview : UserControl
    {
        public AdminReview()
        {
            InitializeComponent();
        }

        private static AdminReview _instance;
        public static AdminReview Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminReview();
                return _instance;
            }
        }
    }
}
