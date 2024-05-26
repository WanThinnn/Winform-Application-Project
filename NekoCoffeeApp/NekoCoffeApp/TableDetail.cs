using FireSharp.Config;
using FireSharp.Interfaces;
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
    public partial class TableDetail : Form
    {
        public TableDetail()
        {
            InitializeComponent();
        }


        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient tbd;

        private void TableDetail_Load(object sender, EventArgs e)
        {
            try
            {
                tbd = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Kiểm tra lại mạng", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            viewData();
        }



        void viewData()
        {
            var data = tbd.Get(@"/Tables");
            var mList = JsonConvert.DeserializeObject<IDictionary<string, NekoTable>>(data.Body);
            var listNumber = mList.Values.ToList();
            TableDetailsView.DataSource = listNumber;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}

