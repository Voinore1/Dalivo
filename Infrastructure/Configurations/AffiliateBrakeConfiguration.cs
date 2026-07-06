using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class AffiliateBrakeConfiguration : IEntityTypeConfiguration<AffiliateBrake>
{
    public void Configure(EntityTypeBuilder<AffiliateBrake> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.WorkingDay)
            .WithMany(x => x.Brakes)
            .HasForeignKey(x => x.WorkingDayId);
    }
}