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
    public class NekoTable
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }


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

        public static void ShowError_3()
        {
            System.Windows.Forms.MessageBox.Show("Đã được đặt!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static bool IsEqual(NekoTable table1, NekoTable table2)
        {
            if (table1 == null || table2 == null) { return false; }

            if (table1.ID != table2.ID)
            {
                error1 = " không tồn tại!";
                return false;
            }
            return true;
        }

        public static bool IsExist(NekoTable table1, NekoTable table2)
        {
            if (table1 == null || table2 == null) { return false; }

            if (table1.ID != table2.ID)
            {
                error1 = "Nước không tồn tại!";
                return false;
            }


            return true;
        }


        public static bool Search(NekoTable table1, NekoTable table2)
        {
            if (table1 == null || table2 == null) { return false; }

            if (table1.ID != table2.ID)
            {
                System.Windows.Forms.MessageBox.Show("Nước không tồn tại2!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }



}