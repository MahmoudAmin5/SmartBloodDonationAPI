using SmartBloodDonationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace SmartBloodDonationSystem.Domain.Entities
{
    public class BloodUnit
    {
        public int Id { get; set; }
        public string UnitCode { get; set; } = string.Empty;
        public int DonationId { get; set; }
        public int BloodCenterId { get; set; }
        public DateTime? ExpireDate { get; set; }
        public BloodType BloodType { get; set; }
        public int Volume { get; set; }
        public BloodStatus BloodStatus { get; set; } = "Available";
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get;set; }


        public Donation Donation { get; set; }
        public BloodCenter BloodCenter { get; set; }

    }
}
