using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartBloodDonationSystem.Domain.Entities;
using SmartBloodDonationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBloodDonationSystem.Infrastructure.Data.Config
{
    public class BloodUnitConfig : IEntityTypeConfiguration<BloodUnit>
    {
        public void Configure(EntityTypeBuilder<BloodUnit> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.BloodType)
               .HasConversion(Blood => Blood.ToString(), Blood => (BloodType)Enum.Parse(typeof(BloodType), Blood));

            builder.Property(x => x.BloodStatus)
              .HasConversion(Blood => Blood.ToString(), Blood => (BloodStatus)Enum.Parse(typeof(BloodStatus), Blood));

            builder.HasOne(d => d.Donation)
                .WithMany(u => u.BloodUnits)
                .HasForeignKey(k => k.DonationId);
            builder.Property(x => x.BloodType).IsRequired();
            builder.Property(x => x.BloodStatus).IsRequired();


        }
    }
}
