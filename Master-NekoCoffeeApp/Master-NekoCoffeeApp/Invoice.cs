using Aspose.Email.PersonalInfo;
using Firebase.Storage;
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
    public partial class Invoice : Form
    {
        string MasterUsername;
        public Invoice(string masterUsername)
        {
            InitializeComponent();
            MasterUsername = masterUsername;
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient bill;
        FirebaseStorage firebaseStorage;
        async void viewData()
        {
            try
            {
                var data = await bill.GetAsync($"Bills/");

                // Check if data or data.Body is null
                if (data == null || data.Body == null)
                {
                    AdminViewAllYourDrinks.DataSource = null;
                    return;
                }

                string jsonData = data.Body;

                // Kiểm tra xem jsonData có phải là mảng JSON không
                if (jsonData.TrimStart().StartsWith("["))
                {
                    // Nếu là mảng JSON, xử lý nó như một danh sách
                    var mListArray = JsonConvert.DeserializeObject<List<NekoBill>>(jsonData);

                    // Check if mListArray is null or empty
                    if (mListArray == null || !mListArray.Any())
                    {
                        AdminViewAllYourDrinks.DataSource = null;
                        return;
                    }

                    AdminViewAllYourDrinks.DataSource = mListArray;
                }
                else
                {
                    // Nếu không phải mảng JSON, xử lý nó như một đối tượng JSON
                    var mList = JsonConvert.DeserializeObject<IDictionary<string, NekoBill>>(jsonData);

                    // Check if mList is null or empty
                    if (mList == null || !mList.Any())
                    {
                        AdminViewAllYourDrinks.DataSource = null;
                        return;
                    }

                    var listNumber = mList.Values.ToList();
                    AdminViewAllYourDrinks.DataSource = listNumber;
                }
            }
            catch (Exception ex)
            {
                //
                //MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Invoice_Load(object sender, EventArgs e)
        {
            try
            {
                bill = new FireSharp.FirebaseClient(ifc);
                firebaseStorage = new FirebaseStorage("neko-coffe-database.appspot.com");
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
                MessageBox.Show("Vui lòng điền mã hoá đơn", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FirebaseResponse res = bill.Get($"Bills/" + txbSearch.Text);
            NekoBill exbill = res.ResultAs<NekoBill>();

            if (exbill == null)
            {
                MessageBox.Show("Hoá đơn không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            txbID.Text = exbill.billId;
            txbIDTable.Text = exbill.tableId;
            txbPrice.Text = exbill.Total.ToString();
            txbTime.Text = exbill.PaymentTime;



            txbID.BorderColorActive = Color.Silver;
            txbID.BorderColorHover = Color.Silver;
            txbID.BorderColorDisabled = Color.Silver;
            txbID.BorderColorIdle = Color.Silver;

            txbIDTable.BorderColorActive = Color.Silver;
            txbIDTable.BorderColorHover = Color.Silver;
            txbIDTable.BorderColorDisabled = Color.Silver;
            txbIDTable.BorderColorIdle = Color.Silver;

            txbID.ReadOnly = true;
            txbIDTable.ReadOnly = true;

            btnDelete.Enabled = true;


        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbSearch.Text))
            {
                MessageBox.Show("Vui lòng điền mã số hoá đơn!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa hoá đơn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    FirebaseResponse emp = await bill.GetAsync($"/Bills/" + txbID.Text);
                    NekoBill resemp = emp.ResultAs<NekoBill>();

                    if (resemp == null)
                    {
                        MessageBox.Show("Hoá đơn không tồn tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    FirebaseResponse deleteResponse = await bill.DeleteAsync($"/Bills/" + txbID.Text);

                    if (deleteResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show($"Xóa thành công hoá đơn {txbID.Text}!", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Xóa không thành công hoá đơn!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txbSearch.Clear();
            txbID.ReadOnly = false;

            txbID.Clear();
            txbIDTable.Clear();
            txbSearch.Clear();
            txbPrice.Clear();
            txbTime.Clear();




            txbID.BorderColorActive = Color.DodgerBlue;
            txbID.BorderColorHover = Color.FromArgb(105, 181, 255);
            txbID.BorderColorDisabled = Color.Silver;
            txbID.BorderColorIdle = Color.Black;

            txbIDTable.BorderColorActive = Color.DodgerBlue;
            txbIDTable.BorderColorHover = Color.FromArgb(105, 181, 255);
            txbIDTable.BorderColorDisabled = Color.Silver;
            txbIDTable.BorderColorIdle = Color.Black;


            btnDelete.Enabled = false;
            viewData();
        }
    }
}
