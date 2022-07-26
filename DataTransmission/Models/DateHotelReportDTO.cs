using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransmission.Models
{
    internal class DateHotelReportDTO
    {
        public int? Id { get; set; }
        public DateTime? Date { get; set; }
        public string? CreateBy { get; set; }
        public bool? Status {get; set; }
        public int? StoreID { get; set; }
        public float? TotalAmount { get; set; }
        public float? Discount { get; set; }
        public float? FinalAmount { get; set; }
        public float? TotalOrderDetail { get; set; }
        public float? TotalOrderFeeItem { get; set; }
    }
}
