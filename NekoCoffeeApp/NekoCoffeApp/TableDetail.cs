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
        DataTable mydt = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "f5A5LselW6L4lKJHpNGVH6NZHGKIZilErMoUOoLC",
            BasePath = "https://neko-coffe-database-default-rtdb.firebaseio.com/"
        };
        public TableDetail() {}
        private NekoTable _table;
        public TableDetail(NekoTable table)
        {
            InitializeComponent();
            _table = table;
            LoadTableDetails();
        }
        private void LoadTableDetails()
        {
           
        }



        private void TableDetail_Load(object sender, EventArgs e)
        {

        }

        private void TableDetailsAdd_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

