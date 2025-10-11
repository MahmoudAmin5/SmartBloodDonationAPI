using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBloodDonationSystem.Domain.Entities
{
    public class BloodCenter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string? City { get; set; }
        public string PhoneNumber { get; set; }
        public decimal? GeoLat { get; set; }
        public decimal? GeoLng { get; set; }

        public ICollection<Donation> Donations { get; set; } = new List<Donation>();
        public ICollection<BloodUnit> BloodUnits { get; set; } = new List<BloodUnit>();

    }
}
