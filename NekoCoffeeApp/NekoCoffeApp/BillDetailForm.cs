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
    public partial class BillDetailForm : Form
    {
        public BillDetailForm(Bills bill)
        {
            InitializeComponent();
            LoadBillDetails(bill);
        }
        private void LoadBillDetails(Bills bill)
        {
            lblBillId.Text = "Hoa don so " + bill.billId;
            lblTableId.Text = "Ban so " + bill.tableId;
            lblTotal.Text = "Tong cong: " + bill.Total.ToString();
            lblPaymentTime.Text = bill.PaymentTime;

            foreach (var detail in bill.Details)
            {
                listViewDetails.Items.Add(new ListViewItem(new[] { detail.Name, detail.SL.ToString(), detail.Total.ToString() }));
            }
        }

        private void BillDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
