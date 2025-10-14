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
    public class DonorConfig : IEntityTypeConfiguration<Donor>
    {
        public void Configure(EntityTypeBuilder<Donor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User)
                 .WithOne();
            builder.HasMany(d => d.Donations)
                .WithOne(d => d.Donor)
                .HasForeignKey(k => k.DonorId);
            builder.Property(x => x.BloodType).IsRequired();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.Phone).IsRequired();
            builder.Property(x=>x.BloodType)
                .HasConversion(Blood => Blood.ToString(), Blood => (BloodType)Enum.Parse(typeof(BloodType), Blood));

        }
    }
}
