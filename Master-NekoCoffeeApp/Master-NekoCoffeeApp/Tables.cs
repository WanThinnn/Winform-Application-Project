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
        /*    foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Ten Mon"].Value != null && row.Cells["Ten Mon"].Value.ToString() == selectedItem)
                {
                    dataGridView1.Rows.Remove(row);
                    break;
                }
            }*/
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


    }
}
