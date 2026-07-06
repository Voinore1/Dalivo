using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class OrderAdditionalConfiguration : IEntityTypeConfiguration<OrderAdditional>
{
    public void Configure(EntityTypeBuilder<OrderAdditional> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.HasOne(x => x.Additional)
            .WithMany(x => x.OrderAdditionals)
            .HasForeignKey(x => x.AdditionalId);
        
        builder.HasOne(x => x.OrderProduct)
            .WithMany(x => x.OrderAdditionals)
            .HasForeignKey(x => x.OrderProductId);
    }
}