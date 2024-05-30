using FireSharp;
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
using System.Windows.Documents;
using System.Windows.Forms;

namespace UI
{
    public partial class TableDetail : Form
    {
        DataTable mydt = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public TableDetail() {}
        private NekoTable _table;
        public TableDetail(NekoTable table)
        {
            InitializeComponent();
            _table = table;
            LoadTableDetails();
        }
        private async void LoadTableDetails()
        {

        }

        private async void TableDetail_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            mydt.Columns.Add("Ten Mon");
            mydt.Columns.Add("SL");
            mydt.Columns.Add("Gia Tien");

            dataGridView1.DataSource = mydt;
            var response = await client.GetAsync("/Drinks");
            var drinks = JsonConvert.DeserializeObject<Dictionary<string, NekoDrink>>(response.Body);
            foreach (var drink in drinks.Values)
            {
                comboBox1.Items.Add(drink.Name);
            }
            var response1 = await client.GetAsync("/Cats");
            var cats = JsonConvert.DeserializeObject<Dictionary<string, NekoCat>>(response1.Body);
            foreach (var cat in cats.Values)
            {
                comboBox2.Items.Add(cat.Name);
            }
        }

        private void TableDetailsAdd_Click(object sender, EventArgs e)
        {

        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex <= -1 && comboBox2.SelectedIndex <= -1)
            {
                MessageBox.Show("Vui lòng chọn một mục từ sản phẩm.");
                return;
            }

            string selectedNumber = numericUpDown1.Value.ToString();
            string selectedItem;

            if (comboBox1.SelectedIndex >= 0)
            {
                selectedItem = comboBox1.SelectedItem.ToString();
            }
            else
            {
                selectedItem = comboBox2.SelectedItem.ToString();
            }
            SetResponse response = await client.SetAsync("TableDetails/" + _table.ID + "/" + selectedItem, selectedNumber);
        }
    }
}

