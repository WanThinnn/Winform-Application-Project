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
    public partial class AdminAdjust : UserControl
    {
        public AdminAdjust()
        {
            InitializeComponent();
        }

        private static AdminAdjust _instance;
        public static AdminAdjust Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminAdjust();
                return _instance;
            }
        }

        private void AdminAdjust_Load(object sender, EventArgs e)
        {

        }

        private void AdminAdjustCustomer_Click(object sender, EventArgs e)
        {
            CustomerMng form1 = new CustomerMng();
            form1.Show();
        }

        private void AdminAdjustProduct_Click(object sender, EventArgs e)
        {
            ProductMng form1 = new ProductMng();
            form1.Show();
        }

        private void AdminAdjustEmployee_Click(object sender, EventArgs e)
        {
            EmployeeMng form1 = new EmployeeMng();
            form1.Show();
        }

        private void AdminAdjustCat_Click(object sender, EventArgs e)
        {
            CatMng form1 = new CatMng();
            form1.Show();
        }

        private void AdminAdjustTable_Click(object sender, EventArgs e)
        {
            TableMng form1 = new TableMng();
            form1.Show();
        }

        private void AdminAdjustDrink_Click(object sender, EventArgs e)
        {
            DrinkMng form1 = new DrinkMng();
            form1.Show();
        }
    }
}
