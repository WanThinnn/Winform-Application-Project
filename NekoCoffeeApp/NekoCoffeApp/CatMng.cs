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

namespace UI
{
    public partial class CatMng : Form
    {
        public CatMng()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void Cat_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            viewData();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        void viewData()
        {
            var data = client.Get($"/Cats/");

            // Check if data or data.Body is null
            if (data == null || data.Body == null)
            {
                // Optionally, handle the null case here
                UserView.DataSource = null;
                return;
            }

            var mList = JsonConvert.DeserializeObject<IDictionary<string, NekoCat>>(data.Body);

            // Check if mList is null or empty
            if (mList == null || !mList.Any())
            {
                // Optionally, handle the empty case here
                UserView.DataSource = null;
                return;
            }

            var listNumber = mList.Values.ToList();
            UserView.DataSource = listNumber;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (
               string.IsNullOrWhiteSpace(txbIDCat.Text) ||
               string.IsNullOrWhiteSpace(txbNameCat.Text) ||
               string.IsNullOrWhiteSpace(txbPrice.Text) ||
               string.IsNullOrWhiteSpace(txbAvailable.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn thêm mèo này không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    FirebaseResponse cat = await client.GetAsync($"/Cats/" + txbNameCat.Text);
                    NekoCat rescat = cat.ResultAs<NekoCat>();

                    NekoCat curcat = new NekoCat()
                    {
                        Name = txbNameCat.Text
                    };


                    // Nếu ResUser không phải là null, thực hiện kiểm tra
                    if ((rescat != null && NekoCat.Search(rescat, curcat)))
                    {
                        NekoCat.ShowError_2();
                        return;
                    }


                    NekoCat nekoCat = new NekoCat()
                    {
                        ID = txbIDCat.Text,
                        Name = txbNameCat.Text,
                        Price = txbPrice.Text,
                        Available = int.Parse(txbAvailable.Text)

                    };

                    SetResponse set = await client.SetAsync($"/Cats/" + txbNameCat.Text, nekoCat);

                    if (set.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show($"Thêm thành công mèo {txbNameCat.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Thêm không thành công mèo!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    btnRefresh_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbCat_Name.Clear();
            txbIDCat.ReadOnly = false;

            txbIDCat.Clear();
            txbNameCat.Clear();
            txbAvailable.Clear();
            txbPrice.Clear();


            txbIDCat.BorderColorActive = Color.DodgerBlue;
            txbIDCat.BorderColorHover = Color.FromArgb(105, 181, 255);
            txbIDCat.BorderColorDisabled = Color.Silver;
            txbIDCat.BorderColorIdle = Color.Black;


            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            viewData();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCat_Name.Text))
            {
                MessageBox.Show("Vui lòng nhập tên mèo để xóa", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa mèo này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    FirebaseResponse cat = await client.GetAsync($"/Cats/" + txbNameCat.Text);
                    NekoCat rescat = cat.ResultAs<NekoCat>();

                    if (rescat == null)
                    {
                        MessageBox.Show("Mèo không tồn tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    FirebaseResponse deleteResponse = await client.DeleteAsync($"/Cats/" + txbNameCat.Text);

                    if (deleteResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show($"Xóa thành công mèo {txbNameCat.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Xóa không thành công mèo!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    btnRefresh_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCat_Name.Text))
            {
                MessageBox.Show("Vui lòng điền tên mèo!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = client.Get($"/Cats/" + tbCat_Name.Text);
            NekoCat cat = res.ResultAs<NekoCat>();

            if (cat == null)
            {
                MessageBox.Show("Mèo không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txbIDCat.ReadOnly = true;


            txbIDCat.BorderColorActive = Color.Silver;
            txbIDCat.BorderColorHover = Color.Silver;
            txbIDCat.BorderColorDisabled = Color.Silver;
            txbIDCat.BorderColorIdle = Color.Silver;


            txbIDCat.Text = cat.ID;
            txbNameCat.Text = cat.Name;
            txbPrice.Text = cat.Price.ToString();
            txbAvailable.Text = cat.Available.ToString();
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCat_Name.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin mèo này không?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    FirebaseResponse res = await client.GetAsync($"/Cats/" + tbCat_Name.Text);
                    if (res.Body == "null")
                    {
                        MessageBox.Show("Mèo này không tồn tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    NekoCat cat = res.ResultAs<NekoCat>();

                    var updateData = new NekoCat
                    {
                        ID = cat.ID,
                        Name = txbNameCat.Text,
                        Available = int.Parse(txbAvailable.Text),
                        Price = txbPrice.Text,
                    };

                    // Tạo mục mới với tên mới
                    SetResponse up = await client.SetAsync($"/Cats/" + txbNameCat.Text, updateData);
                    if (up.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        // Xóa mục cũ sau khi tạo mục mới thành công
                        FirebaseResponse deleteResponse = await client.DeleteAsync($"/Cats/" + tbCat_Name.Text);
                        if (deleteResponse.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show($"Sửa thông tin thành công và cập nhật tên mèo {tbCat_Name.Text} thành {txbNameCat.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thành công nhưng không thể xóa mèo cũ!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin thất bại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnRefresh_Click(sender, e);
            }
        }
    }
}
