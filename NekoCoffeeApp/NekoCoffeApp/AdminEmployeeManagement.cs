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

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        private void Signup_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AdminAddEmployee_Click(object sender, EventArgs e)
        {
           se res = client.Get(@"Users/" + AdminFillEmployeeUserName.text);
            NekoUser ResUser = res.ResultAs<NekoUser>();

            NekoUser employee = new NekoUser()
            {
                EmployeeName = AdminFillEmployeeName.text,
                Password = "",
                DateOfBirth = AdminFillEmployeeDateOfBirth.text,
                Gender = AdminFillEmployeeGender.text,
                Address = AdminFillEmployeeAddress.text,
                PhoneNumber = AdminFillEmployeePhoneNumber.text,
                Email = AdminFillEmployeeEmail.text,
                Salary = AdminFillEmployeeSalary.text
            };

            setresponse set = client.set(@"users/" + txtusername.text, user);

        }
    }
}
