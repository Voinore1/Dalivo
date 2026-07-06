using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;


public class AffiliateWorkingDayConfiguration : IEntityTypeConfiguration<AffiliateWorkingDay>
{
    public void Configure(EntityTypeBuilder<AffiliateWorkingDay> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Affiliate)
            .WithMany(x => x.WorkingDays)
            .HasForeignKey(x => x.AffiliateId);
    }
}