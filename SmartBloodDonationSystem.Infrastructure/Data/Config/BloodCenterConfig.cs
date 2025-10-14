using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartBloodDonationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBloodDonationSystem.Infrastructure.Data.Config
{
    public class BloodCenterConfig : IEntityTypeConfiguration<BloodCenter>
    {
        public void Configure(EntityTypeBuilder<BloodCenter> builder)
        {
           builder.HasKey(x => x.Id);
            builder.HasMany(d => d.Donations)
                .WithOne(c => c.BloodCenter)
                .HasForeignKey(c => c.BloodCenterId);
            builder.HasMany(u => u.BloodUnits)
                .WithOne(c => c.BloodCenter)
                .HasForeignKey(k => k.BloodCenterId);
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Address).IsRequired();
        }
    }
}
