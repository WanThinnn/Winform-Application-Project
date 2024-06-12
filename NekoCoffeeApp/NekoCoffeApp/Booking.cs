using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public class Booking
    {
        public string Username { get; set; }
        public string BookingTime { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public static void ShowError_1()
        {
            System.Windows.Forms.MessageBox.Show("Mỗi tài khoản chỉ được đánh giá một lần!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool Search(Booking book1, Booking book2)
        {
            if (book1 == null || book2 == null) { return false; }

            if (book1.Username != book2.Username)
            {
                System.Windows.Forms.MessageBox.Show("Nước không tồn tại2!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }

}
