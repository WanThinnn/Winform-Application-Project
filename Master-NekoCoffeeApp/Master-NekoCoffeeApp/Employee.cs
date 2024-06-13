using Aspose.Email.Clients.ActiveSync.TransportLayer;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_NekoCoffeeApp
{
    public partial class Employee : Form
    {
        string MasterUsername;
        public Employee(string MasterUsername)
        {
            InitializeComponent();
            this.MasterUsername = MasterUsername;
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void Employee_Load(object sender, EventArgs e)
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
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Kiểm tra định dạng email
                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return regex.IsMatch(email);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        async void viewData()
        {
            try
            {
                var data = await client.GetAsync($"/Employees/");

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
                    var mListArray = JsonConvert.DeserializeObject<List<NekoEmployee>>(jsonData);

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
                    var mList = JsonConvert.DeserializeObject<IDictionary<string, NekoEmployee>>(jsonData);

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




        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (
               string.IsNullOrWhiteSpace(txbIDEmployee.Text) ||
               string.IsNullOrWhiteSpace(txbNameEmployee.Text) ||
               string.IsNullOrWhiteSpace(txbEmail.Text) ||
               string.IsNullOrWhiteSpace(txbBirthday.Text) ||
               string.IsNullOrWhiteSpace(txbSalary.Text) ||
               string.IsNullOrWhiteSpace(dbGender.Text) ||
               string.IsNullOrWhiteSpace(txbPhone.Text) ||
               string.IsNullOrWhiteSpace(txbAdrr.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn thêm nhân viên này không?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    FirebaseResponse emp = await client.GetAsync($"/Employees/" + txbIDEmployee.Text);
                    NekoEmployee resemp = emp.ResultAs<NekoEmployee>();

                    NekoEmployee curemp = new NekoEmployee()
                    {
                        ID = txbIDEmployee.Text
                       

                    };


                    // Nếu ResUser không phải là null, thực hiện kiểm tra
                    if ((resemp != null && NekoEmployee.Search(resemp, curemp)))
                    {
                        NekoEmployee.ShowError_2();
                        return;
                    }
                    // Kiểm tra tính hợp lệ của email
                    if (!IsValidEmail(txbEmail.Text.ToLower()))
                    {
                        MessageBox.Show("Email không hợp lệ!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    NekoEmployee newemp = new NekoEmployee()
                    {
                        ID = txbIDEmployee.Text,
                        Name = txbNameEmployee.Text,
                        Email = txbEmail.Text,
                        PhoneNumber = txbPhone.Text,
                        Salary = int.Parse(txbSalary.Text),
                        Address = txbAdrr.Text,
                        Gender = dbGender.Text,
                        DateOfBirth = txbBirthday.Text,
                        Shift = txbShift.Text

                    };

                    SetResponse set = await client.SetAsync($"/Employees/" + txbIDEmployee.Text, newemp);

                    if (set.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show($"Thêm thành công nhân viên {txbIDEmployee.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Thêm không thành công nhân viên!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            tbIDEmployee.Clear();
            txbIDEmployee.ReadOnly = false;

            txbIDEmployee.Clear();
            txbNameEmployee.Clear();
            txbPhone.Clear();
            txbSalary.Clear();
            txbEmail.Clear();
            txbAdrr.Clear();
            dbGender.Text = string.Empty;

            txbBirthday.Clear();


            txbIDEmployee.BorderColorActive = Color.DodgerBlue;
            txbIDEmployee.BorderColorHover = Color.FromArgb(105, 181, 255);
            txbIDEmployee.BorderColorDisabled = Color.Silver;
            txbIDEmployee.BorderColorIdle = Color.Black;


            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            viewData();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIDEmployee.Text))
            {
                MessageBox.Show("Vui lòng điền mã số nhân viên!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = client.Get($"/Employees/" + tbIDEmployee.Text);
            NekoEmployee emp = res.ResultAs<NekoEmployee>();

            if (emp == null)
            {
                MessageBox.Show("Nhân viên không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txbIDEmployee.ReadOnly = true;


            txbIDEmployee.BorderColorActive = Color.Silver;
            txbIDEmployee.BorderColorHover = Color.Silver;
            txbIDEmployee.BorderColorDisabled = Color.Silver;
            txbIDEmployee.BorderColorIdle = Color.Silver;


            txbIDEmployee.Text = emp.ID;
            txbNameEmployee.Text = emp.Name;
            txbBirthday.Text = emp.DateOfBirth;
            txbPhone.Text = emp.PhoneNumber;
            txbSalary.Text = emp.Salary.ToString();
            txbAdrr.Text = emp.Address;
            txbEmail.Text = emp.Email;
            dbGender.Text = emp.Gender;

            
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIDEmployee.Text))
            {
                MessageBox.Show("Vui lòng điền mã số nhân viên!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    FirebaseResponse emp = await client.GetAsync($"/Employees/" + txbIDEmployee.Text);
                    NekoEmployee resemp = emp.ResultAs<NekoEmployee>();

                    if (resemp == null)
                    {
                        MessageBox.Show("Nhân viên không tồn tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    FirebaseResponse deleteResponse = await client.DeleteAsync($"/Employees/" + txbIDEmployee.Text);

                    if (deleteResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show($"Xóa thành công nhân viên {txbIDEmployee.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Xóa không thành công nhân viên!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrWhiteSpace(txbIDEmployee.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin nhân viên này không?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    FirebaseResponse res = await client.GetAsync($"/Employees/" + txbIDEmployee.Text);
                    if (res.Body == "null")
                    {
                        MessageBox.Show("Nhân viên này không tồn tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    NekoEmployee emp = res.ResultAs<NekoEmployee>();

                    var updateData = new NekoEmployee
                    {
                        ID = txbIDEmployee.Text,
                        Name = txbNameEmployee.Text,
                        Email = txbEmail.Text,
                        PhoneNumber = txbPhone.Text,
                        Salary = int.Parse(txbSalary.Text),
                        Address = txbAdrr.Text,
                        Gender = dbGender.Text,
                        DateOfBirth = txbBirthday.Text,
                        Shift = txbShift.Text
                    };

                    // Tạo mục mới với tên mới
                    SetResponse up = await client.SetAsync($"/Employees/" + txbIDEmployee.Text, updateData);
                    if (up.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Cập nhật nhân viên thành công!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
