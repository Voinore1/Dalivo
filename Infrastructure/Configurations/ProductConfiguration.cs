using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(64);
        
        builder.Property(x => x.Description)
            .HasMaxLength(512);
        
        builder.Property(x => x.Weight)
            .HasColumnType("decimal(10,2)");
        
        builder.Property(x => x.BasePrice)
            .HasColumnType("decimal(10,2)");
        
        builder.HasOne(x => x.Category)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.CategoryId);
    }
}