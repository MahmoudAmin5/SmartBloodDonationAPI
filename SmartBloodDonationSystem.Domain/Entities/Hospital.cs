using Microsoft.EntityFrameworkCore.Infrastructure;
using SmartBloodDonationSystem.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace SmartBloodDonationSystem.Domain.Entities
{
    public class Hospital
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public AppUser User { get; set; }
        public ICollection<Donation> Donations { get; set; } = new List<Donation>();
    }
}
