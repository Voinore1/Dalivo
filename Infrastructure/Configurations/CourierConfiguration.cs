using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class CourierConfiguration : IEntityTypeConfiguration<Courier>
{
    public void Configure(EntityTypeBuilder<Courier> builder)
    {
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Balance)
            .HasColumnType("decimal(10,2)");
        
        builder.HasOne(x => x.User)
            .WithMany(x => x.Couriers)
            .HasForeignKey(x => x.UserId);

        builder.Property(x => x.CreatedAt)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
    }
}