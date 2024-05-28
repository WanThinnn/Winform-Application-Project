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
            lbTableID.Text = "ID: "+_table.ID;
            lbTableName.Text = "Name: "+_table.Name;
            lbTableStatus.Text = "Status: "+_table.Status;
            AdminOrderTableLabel.Text = _table.Name;
        }






        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}

