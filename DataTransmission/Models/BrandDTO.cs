using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransmission.Models
{
    internal class BrandDTO
    {
        public int? Id { get; set; }
        public string? BrandName { get; set; }  
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }
        public string? Description { get; set; }
        public string? CompanyName { get; set; } 
        public string? ContactPerson { get; set; } 
        public string? PhoneNumber { get; set; }
        public string? Fax { get; set; } 
        public string? Website { get; set; }
        public string? VATCode { get; set; }
        public int? VATTemplate { get; set; }
        public string? Address { get; set; }
        public string? ApiSMSKey { get; set; }
        public string? SecurityApiSMSKey { get; set; }
        public int? SMSType { get; set; }
        public string? BrandNameSMS { get; set; }
        public string? JsonConfigUrl { get; set; }
        public string? BrandFeatureFilter { get; set; }
        public int? WiskyId { get; set; }
        public string? DefaultDashBoard { get; set; }
        public string? RSAPrivateKey { get; set; }
        public string? RSAPublicKey { get; set; }
        public string? PGPPassword { get; set; }
        public string? PGPPrivateKey { get; set; }
        public string? PGPPulblicKey { get; set; }
        public string? DesKey { get; set; }
        public string? DesVector { get; set; }
        public string? AccessToken { get; set; }
        public string? TaxCode { get; set; }
    }
}
