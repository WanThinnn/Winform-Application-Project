using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_NekoCoffeeApp
{
    internal class NekoCat
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Available { get; set; }

        public int Price { get; set; }


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
        public static bool IsEqual(NekoCat cat1, NekoCat cat2)
        {
            if (cat1 == null || cat2 == null) { return false; }

            if (cat1.ID != cat2.ID)
            {
                error1 = " không tồn tại!";
                return false;
            }
            return true;
        }

        public static bool IsExist(NekoCat cat1, NekoCat cat2)
        {
            if (cat1 == null || cat2 == null) { return false; }

            if (cat1.ID != cat2.ID)
            {
                error1 = "Mèo không tồn tại!";
                return false;
            }


            return true;
        }


        public static bool Search(NekoCat cat1, NekoCat cat2)
        {
            if (cat1 == null || cat2 == null) { return false; }

            if (cat1.ID != cat2.ID)
            {
                //System.Windows.Forms.MessageBox.Show("Mèo không tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
