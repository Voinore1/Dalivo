using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
{
    public void Configure(EntityTypeBuilder<OrderProduct> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.HasOne(x => x.Order)
            .WithMany(x => x.OrderProducts)
            .HasForeignKey(x => x.OrderId);
        
        builder.HasOne(x => x.Product)
            .WithMany(x => x.OrderProducts)
            .HasForeignKey(x => x.ProductId);
    }
}