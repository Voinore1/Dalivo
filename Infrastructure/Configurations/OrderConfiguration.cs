using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.ProductPrice)
            .HasColumnType("decimal(10,2)");
        
        builder.Property(x => x.DeliveryPrice)
            .HasColumnType("decimal(10,2)");
        
        builder.Property(x => x.ServiceFee)
            .HasColumnType("decimal(10,2)");
        
        builder.Property(x => x.Tip)
            .HasColumnType("decimal(10,2)");

        builder.Property(x => x.Status)
            .HasConversion<int>();
        
        builder.HasOne(x => x.Courier)
            .WithMany(x => x.Orders)
            .HasForeignKey(x => x.CourierId);
        
        builder.HasOne(x => x.Customer)
            .WithMany(x => x.CustomerOrders)
            .HasForeignKey(x => x.CustomerId);
        
        builder.HasOne(x => x.Affiliate)
            .WithMany(x => x.Orders)
            .HasForeignKey(x => x.AffiliateId);
        
        builder.HasOne(x => x.Rating)
            .WithOne(x => x.Order)
            .HasForeignKey<Rating>(x => x.OrderId)
            .IsRequired(false);
        
    }
}