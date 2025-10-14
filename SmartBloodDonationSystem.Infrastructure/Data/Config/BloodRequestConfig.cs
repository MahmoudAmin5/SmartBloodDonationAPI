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
    public class BloodRequestConfig : IEntityTypeConfiguration<BloodRequest>
    {
        public void Configure(EntityTypeBuilder<BloodRequest> builder)
        {
           builder.HasKey(x => x.Id);
            builder.HasOne(h => h.Hospital)
                .WithMany(h => h.BloodRequests)
                .HasForeignKey(k => k.HospitalId);
            builder.Property(x => x.UnitsAmount).IsRequired();
            builder.Property(x=>x.BloodType).IsRequired();

        }
    }
}
