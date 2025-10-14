using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SmartBloodDonationSystem.Domain.Enums
{
    public enum RequestStatus
    {
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Cancelled")]
        Cancelled,
        [EnumMember(Value = "Fulfilled")]
        Fulfilled


    }
}
