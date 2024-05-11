using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    internal class Nekoemployee
    {
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Salary { get; set; }
        public string UserName { get; set; }


        private static string error1 = "Không tồn tại!";
        private static string error2 = "Cảnh báo";

        public static void ShowError()
        {

            System.Windows.Forms.MessageBox.Show(error1, error2, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError_2()
        {
            System.Windows.Forms.MessageBox.Show("Không tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool IsEqual(NekoEmployee employee1, NekoEmployee employee2)
        {
            if (employee1 == null || employee2== null) { return false; }

            if (employee1.Name != employee2.Name)
            {
                error1 = "Nhân viên không tồn tại!";
                return false;
            }
            return true;
        }

        public static bool IsExist(NekoEmployee employee1, NekoEmployee employee2)
        {
            if (employee1 == null || employee2== null) { return false; }

            if (employee1.Username != employee2.Username || employee1.Email != employee2.Email || employee1.PhoneNumber != employee2.PhoneNumber)
            {
                error1 = "Tài khoản không tồn tại!";
                return false;
            }


            return true;
        }


        public static bool Search(NekoEmployee employee1, NekoEmployee employee2)
        {
            if (employee1 == null || employee2== null) { return false; }

            if (employee1.Username != employee2.Username)
            {
                System.Windows.Forms.MessageBox.Show("Tài khoản không tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
