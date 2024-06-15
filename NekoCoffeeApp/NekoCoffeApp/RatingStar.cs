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
using System.Windows.Documents;
using System.Windows.Forms;

namespace UI
{
    public partial class RatingStar : Form
    {
        //public event EventHandler<NekoRating> RateAdded;
        public RatingStar()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient tb;

        private void RatingStar_Load(object sender, EventArgs e)
        {
            try
            {
                tb = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbComment.Text))
            {
                MessageBox.Show("Vui lòng điền nhận xét trước khi gửi!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ratingStars.Value  == 0)
            {
                MessageBox.Show("Vui đánh giá trước khi gửi!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (GlobalVars.CurrentUser == null)
            {
                MessageBox.Show("Bạn cần đăng nhập để thực hiện đánh giá!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            } else
            {
                string fullname = GlobalVars.CurrentUser.Fullname;

                FirebaseResponse res = tb.Get(@"Ratings/" + fullname);
                NekoRating ResTable = res.ResultAs<NekoRating>();

                NekoRating CurTable = new NekoRating()
                {
                    Fullname = fullname
                };

                if (NekoRating.Search(ResTable, CurTable))
                {
                    NekoRating.ShowError_1();
                    return;
                }

                NekoRating rate = new NekoRating()
                {
                    Fullname = fullname,
                    Star = ratingStars.Value,
                    Comment = tbComment.Text,
                };

                SetResponse set = tb.Set(@"Ratings/" + fullname, rate);

                if (set.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    tbComment.Text = "";
                    ratingStars.Value = 0;
                    MessageBox.Show($"Tài khoản {fullname} đã gửi một nhận xét!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /*RateAdded?.Invoke(this, rate); // Kích hoạt sự kiện TableAdded
                    viewData();*/
                }
            }

        }
    }
}
