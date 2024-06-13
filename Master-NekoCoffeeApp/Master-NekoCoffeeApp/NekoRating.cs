using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_NekoCoffeeApp
{
    internal class NekoRating
    {

        public string Fullname { get; set; }
        public int Star { get; set; }
        public string Comment { get; set; }

        public static void ShowError_1()
        {
            System.Windows.Forms.MessageBox.Show("Mỗi tài khoản chỉ được đánh giá một lần!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool Search(NekoRating rate1, NekoRating rate2)
        {
            if (rate1 == null || rate2 == null) { return false; }

            if (rate1.Fullname != rate2.Fullname)
            {
                //System.Windows.Forms.MessageBox.Show("Nước không tồn tại2!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
