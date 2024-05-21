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
    public partial class AdminFinancial : UserControl
    {
        public AdminFinancial()
        {
            InitializeComponent();
        }

        private static AdminFinancial _instance;
        public static AdminFinancial Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminFinancial();
                return _instance;
            }
        }

        private void AdminFinancialMoney_Click(object sender, EventArgs e)
        {

        }

        private void AdminFinancial_Load(object sender, EventArgs e)
        {

        }
    }
}
