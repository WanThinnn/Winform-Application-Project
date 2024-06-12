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
using System.Xml.Linq;

namespace Master_NekoCoffeeApp
{
    public partial class Tables : Form
    {
        string MasterUsername;
        public Tables(string masterUsername)
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
                var data = await client.GetAsync($"/Tables/");

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
                    var mListArray = JsonConvert.DeserializeObject<List<NekoTable>>(jsonData);

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
                    var mList = JsonConvert.DeserializeObject<IDictionary<string, NekoTable>>(jsonData);

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

        private void Tables_Load(object sender, EventArgs e)
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

        private async void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbID.Text))
            {
                MessageBox.Show("Vui lòng điền mã số bàn!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = client.Get($"/Tables/");

            if (res == null || res.Body == "null")
            {
                MessageBox.Show("Không thể lấy dữ liệu từ Firebase.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<NekoTable> tables = null;

            try
            {
                tables = res.ResultAs<List<NekoTable>>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xử lý dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tables == null || tables.Count == 0)
            {
                MessageBox.Show("Không tìm thấy bàn nào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure that tables and each element within it is not null
            NekoTable table = tables.FirstOrDefault(t => t != null && t.ID == tbID.Text);

            if (table == null)
            {
                MessageBox.Show("Bàn không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txbID.ReadOnly = true;

            txbID.BorderColorActive = Color.Silver;
            txbID.BorderColorHover = Color.Silver;
            txbID.BorderColorDisabled = Color.Silver;
            txbID.BorderColorIdle = Color.Silver;

            txbID.Text = table.ID;
            txbName.Text = table.Name;
            dbStatus.Text = table.Status;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (
              string.IsNullOrWhiteSpace(txbID.Text) ||
              string.IsNullOrWhiteSpace(txbName.Text) ||
              string.IsNullOrWhiteSpace(dbStatus.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn thêm bàn này không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    FirebaseResponse emp = await client.GetAsync($"/Tables/" + txbID.Text);
                    NekoTable restbl = emp.ResultAs<NekoTable>();

                    NekoTable curtbl = new NekoTable()
                    {
                        ID = txbID.Text


                    };


                    // Nếu ResUser không phải là null, thực hiện kiểm tra
                    if ((restbl != null && NekoTable.Search(restbl, curtbl)))
                    {
                        NekoTable.ShowError_2();
                        return;
                    }
                 

                    NekoTable newtbl = new NekoTable()
                    {
                        ID = txbID.Text,
                        Name = txbName.Text,
                        Status = dbStatus.Text,


                    };

                    SetResponse set = await client.SetAsync($"/Tables/" + txbID.Text, newtbl);

                    if (set.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show($"Thêm thành công bàn {txbID.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Thêm không thành công bàn!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txbID.Clear();
            txbID.ReadOnly = false;

            txbID.Clear();
            txbName.Clear();
            dbStatus.Text = string.Empty;



            txbID.BorderColorActive = Color.DodgerBlue;
            txbID.BorderColorHover = Color.FromArgb(105, 181, 255);
            txbID.BorderColorDisabled = Color.Silver;
            txbID.BorderColorIdle = Color.Black;


            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            viewData();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbID.Text))
            {
                MessageBox.Show("Vui lòng điền mã số bàn!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa bàn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    FirebaseResponse emp = await client.GetAsync($"/Tables/" + tbID.Text);
                    NekoTable resemp = emp.ResultAs<NekoTable>();

                    if (resemp == null)
                    {
                        MessageBox.Show("Nhân viên không tồn tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    FirebaseResponse deleteResponse = await client.DeleteAsync($"/Tables/" + tbID.Text);
                      
                    if (deleteResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show($"Xóa thành công bàn {txbID.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Xóa không thành công bàn {txbID.Text}!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    btnRefresh_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbID.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin bàn này không?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    FirebaseResponse res = await client.GetAsync($"/Tables/" + tbID.Text);
                    if (res.Body == "null")
                    {
                        MessageBox.Show("Nhân viên này không tồn tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    NekoTable emp = res.ResultAs<NekoTable>();

                    var updateData = new NekoTable
                    {
                        ID = txbID.Text,
                        Name = txbName.Text,
                        Status = dbStatus.Text,

                    };

                    // Tạo mục mới với tên mới
                    SetResponse up = await client.SetAsync($"/Tables/" + tbID.Text, updateData);
                    if (up.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show($"Cập nhật bàn {tbID.Text} thành công!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
