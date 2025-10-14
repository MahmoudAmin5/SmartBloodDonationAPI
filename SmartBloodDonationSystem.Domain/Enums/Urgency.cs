using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SmartBloodDonationSystem.Domain.Enums
{
    public enum Urgency
    {
        [EnumMember(Value = "Normal")]
        Normal,
        [EnumMember(Value = "Urgent")]
        Urgent,
        [EnumMember(Value = "Critical")]
        Critical
    }
}
