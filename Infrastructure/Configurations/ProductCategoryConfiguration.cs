using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasMaxLength(32);
        
        builder.HasOne(x => x.Affiliate)
            .WithMany(x => x.ProductCategories)
            .HasForeignKey(x => x.AffiliateId);
        
        builder.HasOne(x => x.Category)
            .WithMany(x => x.ProductCategories)
            .HasForeignKey(x => x.ProductCategoryId);
    }
}