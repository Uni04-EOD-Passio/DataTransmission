using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransmission.Models
{
    internal class DateReportDTO
    {
		public int ID{ get; set; }
        public DateTime? Date { get; set; }
		public string? CreateBy { get; set; }
		public int? Status { get; set; }
		public int? StoreID { get; set; }
		public float? TotalAmount { get; set; }
 		public float? FinalAmount { get; set; }
		public float? Discount { get; set; }
		public float? DiscountOrderDetail { get; set; }
		public float? TotalCash { get; set; }
		public int? TotalOrder { get; set; }
		public int? TotalOrderAtStore { get; set; }
		public int? TotalOrderTakeAway { get; set; }
		public int? TotalOrderDelivery { get; set; }
		public float? TotalOrderDetail { get; set; }
		public float? TotalOrderFeeItem { get; set; }
		public int? TotalOrderCard { get; set; }
		public int? TotalOrderCanceled { get; set; }
		public int? TotalOrderPreCanceled { get; set; }
		public float? FinalAmountAtStore { get; set; }
		public float FinalAmountTakeAway { get; set; }
		public float FinalAmountDelivery { get; set; }
		public float FinalAmountCard { get; set; }
		public float FinalAmountCanceled { get; set; }
		public float FinalAmountPreCanceled { get; set; }
    }
}
