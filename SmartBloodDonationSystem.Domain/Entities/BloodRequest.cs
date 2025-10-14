using SmartBloodDonationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SmartBloodDonationSystem.Domain.Entities
{
    public class BloodRequest
    {
        public int Id { get; set; }
        public int HospitalId { get; set; }
        public BloodType BloodType { get; set; }
        public RequestStatus Status { get; set; } = RequestStatus.Pending;
        public Urgency Urgency { get; set; } = Urgency.Normal; 
        public int UnitsAmount { get; set; }

        public DateTime? NeededByDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public Hospital  Hospital { get; set; }

    }
}
