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
    public class DonationConfig : IEntityTypeConfiguration<Donation>
    {
        public void Configure(EntityTypeBuilder<Donation> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Donor)
                .WithMany(x => x.Donations)
                .HasForeignKey(x => x.DonorId);

            builder.HasMany(x => x.BloodUnits)
                .WithOne(x => x.Donation)
                .HasForeignKey(k => k.DonationId);

            builder.Property(x => x.DonationDate).IsRequired();

            builder.Property(x => x.Volume).IsRequired();


        }
    }
}
