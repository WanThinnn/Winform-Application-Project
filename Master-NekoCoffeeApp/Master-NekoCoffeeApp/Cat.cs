using Aspose.Email.Clients.ActiveSync.TransportLayer;
using Aspose.Email.PersonalInfo;
using BCrypt.Net;
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
    public partial class Cat : Form
    {
        string MasterUsername;
        public Cat(string MasterUsername)
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
            var data = client.Get($"/Cats_{MasterUsername}/");

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
                    FirebaseResponse cat = await client.GetAsync($"/Cats_{MasterUsername}/" + txbNameCat.Text);
                    NekoCat rescat = cat.ResultAs<NekoCat>();

                    NekoCat curcat = new NekoCat()
                    {
                        Name = txbNameCat.Text
                    };


                    // Nếu ResUser không phải là null, thực hiện kiểm tra
                    if ((rescat != null && NekoCat.Search(rescat, curcat)))
                    {
                        NekoUser.ShowError_2();
                        return;
                    }


                    NekoCat nekoCat = new NekoCat()
                    {
                        ID = txbIDCat.Text,
                        Name = txbNameCat.Text,
                        Price = int.Parse(txbPrice.Text),
                        Available = txbAvailable.Text

                    };

                    SetResponse set = await client.SetAsync($"/Cats_{MasterUsername}/" + txbNameCat.Text, nekoCat);

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
            txbIDCat.ReadOnly = false;

            txbIDCat.Clear();
            txbNameCat.Clear();
            txbAvailable.Clear();
            txbPrice.Clear();


            txbIDCat.BorderColorActive = Color.DodgerBlue;
            txbIDCat.BorderColorHover = Color.FromArgb(105, 181, 255);
            txbIDCat.BorderColorDisabled = Color.Silver;
            txbIDCat.BorderColorIdle = Color.Black;



            viewData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
