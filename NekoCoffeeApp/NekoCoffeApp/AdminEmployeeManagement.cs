using Aspose.Email.PersonalInfo;
using BCrypt.Net;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace UI
{
    public partial class AdminEmployeeManagement : UserControl
    {

        public AdminEmployeeManagement()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient emp;
        private void AdminEmployeeManagement_Load(object sender, EventArgs e)
        {

            try
            {
                emp = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            viewData();

        }

        private void AdminAddEmployee_Click(object sender, EventArgs e)
        {
            if (
               string.IsNullOrWhiteSpace(AdminFillEmployeeDateOfBirth.Text) ||
               string.IsNullOrWhiteSpace(AdminFillEmployeeGender.Text) ||
            string.IsNullOrWhiteSpace(AdminFillEmployeeAddress.Text) ||
               string.IsNullOrWhiteSpace(AdminFillEmployeePhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(AdminFillEmployeeUserName.Text) ||
               string.IsNullOrWhiteSpace(AdminFillEmployeeSalary.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
 
            FirebaseResponse res = emp.Get(@"Employees/" + AdminFillEmployeeUserName.Text);
            NekoEmployee ResEmployee = res.ResultAs<NekoEmployee>();

            NekoEmployee CurEmployee = new NekoEmployee()
            {
                UserName = AdminFillEmployeeUserName.Text
            };

            if (NekoEmployee.Search(ResEmployee, CurEmployee))
            {
                NekoEmployee.ShowError_2();
                return;
            }

            NekoEmployee employee = new NekoEmployee()
            {
                Name = AdminFillEmployeeName.Text,
                DateOfBirth = AdminFillEmployeeDateOfBirth.Text,
                Gender = AdminFillEmployeeGender.Text,
                Address = AdminFillEmployeeAddress.Text,
                PhoneNumber = AdminFillEmployeePhoneNumber.Text,
                Email = AdminFillEmployeeEmail.Text,
                UserName = AdminFillEmployeeUserName.Text,
                Salary = AdminFillEmployeeSalary.Text
            };

            SetResponse set = emp.Set(@"employees/" + AdminFillEmployeeUserName.Text, employee);


            if (set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"Thêm thành công nhân viên {AdminFillEmployeeUserName.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


       

        void viewData()
        {
            var data = emp.Get(@"/employees");
            var mList = JsonConvert.DeserializeObject<IDictionary<string, NekoEmployee>>(data.Body);
            var listNumber = mList.Values.ToList();
            AdminViewAllCustomer.DataSource = listNumber;
        }

        private void AdminShowAllEmployees_Click(object sender, EventArgs e)
        {

        }
    }
}
