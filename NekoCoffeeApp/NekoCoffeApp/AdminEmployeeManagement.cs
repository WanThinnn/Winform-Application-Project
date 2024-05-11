using Aspose.Email.PersonalInfo;
using BCrypt.Net;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class AdminEmployeeManagement : UserControl
    {

        public AdminEmployeeManagement()
        {
            InitializeComponent();
        }

        private void AdminAddEmployee_Click(object sender, EventArgs e)
        {
            //IFirebaseConfig ifc = new FirebaseConfig()
            //{
            //    AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            //    BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
            //};

            //onse res = client.Get(@"Users/" + AdminFillEmployeeUserName.Text);
            //NekoUser ResUser = res.ResultAs<NekoUser>();

            //NekoUser employee = new NekoUser()
            //{
            //    EmployeeName = AdminFillEmployeeName.Text,
            //    Password = ""
            //    DateOfBirth = AdminFillEmployeeDateOfBirth.Text,
            //    Gender = AdminFillEmployeeGender.Text,
            //    Address = AdminFillEmployeeAddress.Text,
            //    PhoneNumber = AdminFillEmployeePhoneNumber.Text,
            //    Email = AdminFillEmployeeUserName.Text,
            //    Salary = AdminFillEmployeeSalary.Text
            //};

            //SetResponse set = client.Set(@"Users/" + txtUserName.Text, user);

        }
    }
}
