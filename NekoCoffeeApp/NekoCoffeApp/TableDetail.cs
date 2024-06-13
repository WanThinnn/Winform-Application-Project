using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class TableDetail : Form
    {
        DataTable mydt = new DataTable();
        private IFirebaseClient client;
        private IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        private void InitializeFirebaseClient()
        {
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                MessageBox.Show("Không thể kết nối đến Firebase. Vui lòng kiểm tra kết nối mạng.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private NekoTable _table;


        private static TableDetail _instance;
        public static TableDetail Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TableDetail();
                return _instance;
            }
        }

        public TableDetail() { }

        public TableDetail(NekoTable table)
        {
            InitializeComponent();
            _table = table;
            InitializeFirebaseClient();
            LoadTableDetails();
        }



        private async void LoadTableDetails()
        {
            try
            {
                FirebaseResponse response = await client.GetAsync($"TableDetails/{_table.ID}");
                string jsonData = response.Body;

                List<NekoTableDetail> tableDetails = new List<NekoTableDetail>();

                if (jsonData.StartsWith("["))
                {
                    tableDetails = JsonConvert.DeserializeObject<List<NekoTableDetail>>(jsonData);
                }
                else
                {
                    var detailsDict = JsonConvert.DeserializeObject<Dictionary<string, NekoTableDetail>>(jsonData);
                    if (detailsDict != null)
                    {
                        tableDetails = detailsDict.Values.ToList();
                    }
                }

                // Kiểm tra nếu tableDetails vẫn rỗng
                

                foreach (var detail in tableDetails)
                {
                    DataRow row = mydt.NewRow();
                    row["Tên Món"] = detail.Name;
                    row["SL"] = detail.SL;
                    row["Thành Tiền"] = detail.Total;
                    mydt.Rows.Add(row);
                }
                dataGridView1.DataSource = mydt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải chi tiết bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void TableDetail_Load(object sender, EventArgs e)
        {
            mydt.Columns.Add("Tên Món");
            mydt.Columns.Add("SL");
            mydt.Columns.Add("Thành Tiền");

            dataGridView1.DataSource = mydt;

            try
            {
                var response = await client.GetAsync("/Drinks");
                string jsonData = response.Body;

                comboBox1.Items.Clear();
                if (jsonData.TrimStart().StartsWith("["))
                {
                    var drinksList = JsonConvert.DeserializeObject<List<NekoDrink>>(jsonData);
                    foreach (var drink in drinksList)
                    {
                        if (drink != null && !string.IsNullOrEmpty(drink.Name))
                        {
                            comboBox1.Items.Add(drink.Name);
                        }
                    }
                }
                else
                {
                    var drinksDict = JsonConvert.DeserializeObject<Dictionary<string, NekoDrink>>(jsonData);
                    foreach (var drink in drinksDict.Values)
                    {
                        if (drink != null && !string.IsNullOrEmpty(drink.Name))
                        {
                            comboBox1.Items.Add(drink.Name);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách đồ uống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                var response = await client.GetAsync("/Cats");
                var catsDict = JsonConvert.DeserializeObject<Dictionary<string, NekoCat>>(response.Body);
                foreach (var cat in catsDict.Values)
                {
                    comboBox2.Items.Add(cat.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách mèo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAddToTable_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (comboBox1.SelectedIndex >= 0 && comboBox2.SelectedIndex >= 0)
            {
                MessageBox.Show("Vui lòng chỉ chọn một sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedNumber = (int)numericUpDown1.Value;
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng của sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedItem;
            int money = 0;

            if (comboBox1.SelectedIndex >= 0)
            {
                selectedItem = comboBox1.SelectedItem?.ToString();
                var response = await client.GetAsync("/Drinks");
                var drinksList = JsonConvert.DeserializeObject<List<NekoDrink>>(response.Body);
                foreach (var drink in drinksList)
                {
                    if (drink?.Name == selectedItem && !string.IsNullOrEmpty(drink.Name))
                    {
                        if (int.TryParse(drink.Price, out int price))
                        {
                            money = price * selectedNumber;
                        }
                    }
                }
            }
            else
            {
                selectedItem = comboBox2.SelectedItem.ToString();
                var response = await client.GetAsync("/Cats");
                var catsDict = JsonConvert.DeserializeObject<Dictionary<string, NekoCat>>(response.Body);
                foreach (var cat in catsDict.Values)
                {
                    if (cat.Name == selectedItem)
                    {
                        if (int.TryParse(cat.Price, out int price))
                        {
                            money = price * selectedNumber;
                        }
                    }
                }
            }

            var data = new NekoTableDetail
            {
                Name = selectedItem,
                SL = selectedNumber,
                Total = money
            };

            try
            {
                SetResponse response1 = await client.SetAsync($"TableDetails/{_table.ID}/{selectedItem}", data);
                if (response1.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Đã thêm món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _table.Status = "Booked";
                    await client.SetAsync($"Tables/{_table.ID}/Status", _table.Status);
                    DataRow row = mydt.NewRow();
                    row["Tên Món"] = selectedItem;
                    row["SL"] = selectedNumber;
                    row["Thành Tiền"] = money;
                    mydt.Rows.Add(row);
                    dataGridView1.DataSource = mydt;
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm món.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm món vào chi tiết bàn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            numericUpDown1.Value = 0;
        }

        private async void TableDetailsDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvRow = dataGridView1.SelectedRows[0];

                string selectedItem = dgvRow.Cells["Tên Món"].Value.ToString();

                try
                {
                    await client.DeleteAsync($"TableDetails/{_table.ID}/{selectedItem}");

                    // Xóa dòng trong DataTable (mydt)
                    DataRow[] foundRows = mydt.Select($"[Tên Món] = '{selectedItem}'");
                    foreach (DataRow dr in foundRows)
                    {
                        mydt.Rows.Remove(dr);
                    }

                    dataGridView1.DataSource = mydt;

                    // Kiểm tra nếu không còn món nào thì chuyển trạng thái bàn về Available
                    if (mydt.Rows.Count == 0)
                    {
                        _table.Status = "Available";
                        await client.SetAsync($"Tables/{_table.ID}/Status", _table.Status);
                    }

                    MessageBox.Show("Đã xóa món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa món: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void TableDetailsView_Click(object sender, EventArgs e)
        {
            try
            {
                mydt.Rows.Clear();
                FirebaseResponse resp2 = await client.GetAsync($"TableDetails/{_table.ID}");
                if (resp2.Body == "null")
                {
                    MessageBox.Show("Bàn này chưa được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string jsonData = resp2.Body;
                if (jsonData.TrimStart().StartsWith("["))
                {
                    var tableDetailsList = JsonConvert.DeserializeObject<List<NekoTableDetail>>(jsonData);
                    foreach (var detail in tableDetailsList)
                    {
                        if (detail != null && !string.IsNullOrEmpty(detail.Name))
                        {
                            DataRow row = mydt.NewRow();
                            row["Tên Món"] = detail.Name;
                            row["SL"] = detail.SL;
                            row["Thành Tiền"] = detail.Total;
                            mydt.Rows.Add(row);
                        }
                    }
                }
                else
                {
                    var tableDetailsDict = JsonConvert.DeserializeObject<Dictionary<string, NekoTableDetail>>(jsonData);
                    foreach (var detail in tableDetailsDict.Values)
                    {
                        if (detail != null && !string.IsNullOrEmpty(detail.Name))
                        {
                            DataRow row = mydt.NewRow();
                            row["Tên Món"] = detail.Name;
                            row["SL"] = detail.SL;
                            row["Thành Tiền"] = detail.Total;
                            mydt.Rows.Add(row);
                        }
                    }
                }
                dataGridView1.DataSource = mydt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void TableDetailsPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Không có món nào trong danh sách để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int total = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    total += Convert.ToInt32(row.Cells["Thành Tiền"].Value);
                }

                FirebaseResponse resp1 = await client.GetAsync("Counter/node");
                var currentBillCount = JsonConvert.DeserializeObject<CountClass>(resp1.Body).count;
                var nextBillCount = int.Parse(currentBillCount) + 1; // Correctly increment the bill count
                var paymentTime = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");

                var tableDetailsDict = new Dictionary<string, NekoTableDetail>();
                foreach (DataRow row in mydt.Rows)
                {
                    var detail = new NekoTableDetail
                    {
                        Name = row["Tên Món"].ToString(),
                        SL = Convert.ToInt32(row["SL"]),
                        Total = Convert.ToInt32(row["Thành Tiền"])
                    };
                    tableDetailsDict[detail.Name] = detail;
                }

                var bill = new Bills
                {
                    billId = nextBillCount.ToString(), // Use the correctly incremented bill count
                    tableId = _table.ID,
                    Total = total,
                    Details = tableDetailsDict.Values.ToList(),
                    PaymentTime = paymentTime
                };

                using (var form = new BillDetailForm(bill))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        DialogResult confirmResult = MessageBox.Show("Bạn có muốn thanh toán bàn này?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirmResult == DialogResult.Yes)
                        {
                            SetResponse response = await client.SetAsync($"Bills/{bill.billId}", bill);
                            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                var updateCount = new CountClass { count = nextBillCount.ToString() };
                                await client.SetAsync("Counter/node", updateCount);
                                await client.DeleteAsync($"TableDetails/{_table.ID}");
                                mydt.Rows.Clear();
                                _table.Status = "Available";
                                await client.SetAsync($"Tables/{_table.ID}/Status", _table.Status);
                                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Có lỗi xảy ra khi lưu hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            numericUpDown1.Value = 0;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                foreach (string s in comboBox1.Items)
                {
                    if (s == Convert.ToString(row.Cells["Tên Món"].Value))
                    {
                        comboBox1.SelectedItem = Convert.ToString(row.Cells["Tên Món"].Value);
                    }
                }
                foreach (string s in comboBox2.Items)
                {
                    if (s == Convert.ToString(row.Cells["Tên Món"].Value))
                    {
                        comboBox2.SelectedItem = Convert.ToString(row.Cells["Tên Món"].Value);
                    }
                }
                numericUpDown1.Value = Convert.ToInt64(row.Cells["SL"].Value);
            }
        }

        public void AddItemToTableDetail(string drinkName, int quantity, int price)
        {
            DataRow row = mydt.NewRow();
            row["Tên Món"] = drinkName;
            row["SL"] = quantity;
            row["Thành Tiền"] = price * quantity;
            mydt.Rows.Add(row);
            dataGridView1.DataSource = mydt;
        }

    }
}

