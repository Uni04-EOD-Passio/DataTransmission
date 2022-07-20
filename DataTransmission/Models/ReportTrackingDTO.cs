using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransmission.Models
{
    internal class ReportTrackingDTO
    {
        public int StoreID { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateUpdate { get; set; }
        public string UpdatePerson { get; set; }
        public bool isUpdate { get; set; }
    }
}
