using Microsoft.AspNetCore.Identity;
using SmartBloodDonationSystem.Domain.Entities.Identity;
using SmartBloodDonationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBloodDonationSystem.Domain.Entities
{
    public class Donor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int? UserId { get; set; }
        public BloodType BloodType { get; set; }
        public string City { get; set; }
        public DateTime LastDonationDate { get; set; }


        public AppUser? User { get; set; }
        public ICollection<Donation> Donations { get; set; } = new List<Donation>(); 

    }
}
