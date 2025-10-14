using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SmartBloodDonationSystem.Domain.Enums
{
    public enum BloodStatus
    {
        [EnumMember(Value = "Available")]
        Available,
        [EnumMember(Value = "Reserved")]
        Reserved,
        [EnumMember(Value = "Used")]
        Used,
        [EnumMember(Value = "Expired")]
        Expired,
        [EnumMember(Value = "Disposed")]
        Disposed
    }
}
