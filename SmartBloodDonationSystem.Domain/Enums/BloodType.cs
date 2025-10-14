using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SmartBloodDonationSystem.Domain.Enums
{
    public enum BloodType
    {
        [EnumMember(Value = "A_Positive")]
        A_Positive,
        [EnumMember(Value = "A_Negative")]
        A_Negative,
        [EnumMember(Value = "B_Positive")]
        B_Positive,
        [EnumMember(Value = "B_Negative")]
        B_Negative,
        [EnumMember(Value = "AB_Positive")]
        AB_Positive,
        [EnumMember(Value = "AB_Negative")]
        AB_Negative,
        [EnumMember(Value = "O_Positive")]
        O_Positive,
        [EnumMember(Value = "O_Negative")]
        O_Negative
    }
}
