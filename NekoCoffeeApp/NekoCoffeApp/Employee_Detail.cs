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
    public partial class EmployeeDetail : Form
    {
        public EmployeeDetail() { }
        private NekoEmployee _employee;
        public EmployeeDetail(NekoEmployee employee)
        {
            InitializeComponent();
            _employee = employee;
            EmployeeDetail_Load();
        }

        private void EmployeeDetail_Load()
        {
            lbEmployeeID.Text = "ID: " + _employee.ID;
            lbEmployeeName.Text = "Name: " + _employee.Name;
            lbEmployeeShift.Text = "Status: " + _employee.Shift;
        }
    }
}
