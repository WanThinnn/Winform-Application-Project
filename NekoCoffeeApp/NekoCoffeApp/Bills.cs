using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class Bills
    {
        public string tableId { get; set; }
        public string billId { get; set; }
        public int Total { get; set; }
        public List<NekoTableDetail> Details { get; set; }
        public string PaymentTime { get; set; } // Thời gian thanh toán

    }
}
