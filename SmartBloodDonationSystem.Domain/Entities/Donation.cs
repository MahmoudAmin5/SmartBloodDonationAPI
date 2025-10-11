using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBloodDonationSystem.Domain.Entities
{
    public class Donation
    {
        public int Id { get; set; }
        public int DonorId { get; set; }
        public int BloodCenterId { get; set; }
        public DateTime DonationDate { get; set; } = DateTime.UtcNow;
        public int Volume { get; set; }
        public string Status { get; set; } = "Completed";
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public Donor Donor { get; set; }
        public BloodCenter BloodCenter { get; set; }
        public ICollection<BloodUnit> BloodUnits { get; set; } = new List<BloodUnit>();

    }
}
