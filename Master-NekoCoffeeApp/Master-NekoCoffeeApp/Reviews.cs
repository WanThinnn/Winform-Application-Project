using Aspose.Email.PersonalInfo;
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

namespace Master_NekoCoffeeApp
{
    public partial class Reviews : Form
    {
        string MasterUsername;
        public Reviews(string masterUsername)
        {
            InitializeComponent();
            MasterUsername = masterUsername;
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        async void viewData()
        {
            try
            {
                var data = await client.GetAsync($"/Ratings/");

                // Check if data or data.Body is null
                if (data == null || data.Body == null)
                {
                    DataView.DataSource = null;
                    return;
                }

                string jsonData = data.Body;

                // Kiểm tra xem jsonData có phải là mảng JSON không
                if (jsonData.TrimStart().StartsWith("["))
                {
                    // Nếu là mảng JSON, xử lý nó như một danh sách
                    var mListArray = JsonConvert.DeserializeObject<List<NekoRating>>(jsonData);

                    // Check if mListArray is null or empty
                    if (mListArray == null || !mListArray.Any())
                    {
                        DataView.DataSource = null;
                        return;
                    }

                    DataView.DataSource = mListArray;
                }
                else
                {
                    // Nếu không phải mảng JSON, xử lý nó như một đối tượng JSON
                    var mList = JsonConvert.DeserializeObject<IDictionary<string, NekoRating>>(jsonData);

                    // Check if mList is null or empty
                    if (mList == null || !mList.Any())
                    {
                        DataView.DataSource = null;
                        return;
                    }

                    var listNumber = mList.Values.ToList();
                   DataView.DataSource = listNumber;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reviews_Load(object sender, EventArgs e)
        {

            txbName.ReadOnly = true;
            txbCmt.ReadOnly = true;

            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            viewData();
            btnDelete.Enabled = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbSearch.Text))
            {
                MessageBox.Show("Vui lòng điền tên người đánh giá!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = client.Get($"/Ratings/" + txbSearch.Text);
            NekoRating rvw = res.ResultAs<NekoRating>();

            if (rvw == null)
            {
                MessageBox.Show("Đánh giá không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            txbName.BorderColorActive = Color.Silver;
            txbName.BorderColorHover = Color.Silver;
            txbName.BorderColorDisabled = Color.Silver;
            txbName.BorderColorIdle = Color.Silver;

            txbCmt.BorderColorActive = Color.Silver;
            txbCmt.BorderColorHover = Color.Silver;
            txbCmt.BorderColorDisabled = Color.Silver;
            txbCmt.BorderColorIdle = Color.Silver;


            txbName.Text = rvw.Fullname;
            txbCmt.Text = rvw.Comment;
            bunifuRating1.Value = rvw.Star;

            btnDelete.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txbSearch.Clear();
            txbName.Clear();
            txbCmt.Clear();
            bunifuRating1.Clear();



            txbName.BorderColorActive = Color.DodgerBlue;
            txbName.BorderColorHover = Color.FromArgb(105, 181, 255);
            txbName.BorderColorDisabled = Color.Silver;
            txbName.BorderColorIdle = Color.Black;



            txbCmt.BorderColorActive = Color.DodgerBlue;
            txbCmt.BorderColorHover = Color.FromArgb(105, 181, 255);
            txbCmt.BorderColorDisabled = Color.Silver;
            txbCmt.BorderColorIdle = Color.Black;

            btnDelete.Enabled = false;
            viewData();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbSearch.Text))
            {
                MessageBox.Show("Vui lòng điền họ tên người đánh giá!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa đánh giá này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    FirebaseResponse emp = await client.GetAsync($"/Ratings/" + txbSearch.Text);
                    NekoRating resemp = emp.ResultAs<NekoRating>();

                    if (resemp == null)
                    {
                        MessageBox.Show("Đánh giá không tồn tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    FirebaseResponse deleteResponse = await client.DeleteAsync($"/Ratings/" + txbSearch.Text);

                    if (deleteResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show($"Xóa thành công đánh giá của {txbName.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Xóa không thành công!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    btnRefresh_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
