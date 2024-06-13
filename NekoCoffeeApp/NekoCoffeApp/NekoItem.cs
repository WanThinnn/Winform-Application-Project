using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    internal class NekoItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Available { get; set; }
        public string Price { get; set; }
        public string Point { get; set; }
        public string Type { get; set; }

        public string ImageURL { get; set; }

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
            System.Windows.Forms.MessageBox.Show("Không tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static bool IsEqual(NekoItem drink1, NekoItem drink2)
        {
            if (drink1 == null || drink2 == null) { return false; }

            if (drink1.ID != drink2.ID)
            {
                error1 = " không tồn tại!";
                return false;
            }
            return true;
        }

        public static bool IsExist(NekoItem drink1, NekoItem drink2)
        {
            if (drink1 == null || drink2 == null) { return false; }

            if (drink1.ID != drink2.ID)
            {
                error1 = "Sản phẩm không tồn tại!";
                return false;
            }


            return true;
        }


        public static bool Search(NekoItem drink1, NekoItem drink2)
        {
            if (drink1 == null || drink2 == null) { return false; }

            if (drink1.ID != drink2.ID)
            {
                //System.Windows.Forms.MessageBox.Show("Sản phẩm không tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
