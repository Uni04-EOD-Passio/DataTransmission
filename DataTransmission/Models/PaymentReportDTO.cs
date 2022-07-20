using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransmission.Models
{
    internal class PaymentReportDTO
    {
        public string CreateBy { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public int StoreID { get; set; }
        public float CashAmount { get; set; }
        public float MemberCardAmount { get; set; }
        public float BankAmount { get; set; }
        public float VoucherAmount { get; set; }
        public float DebtAmount { get; set; }
        public float OtherAmount { get; set; }
        public float PayDebtAmount { get; set; }
        public float ReceiptAmount { get; set; }
        public float SpendAmount { get; set; }
    }
}
