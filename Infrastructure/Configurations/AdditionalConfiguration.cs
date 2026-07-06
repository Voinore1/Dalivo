using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class AdditionalConfiguration : IEntityTypeConfiguration<Additional>
{
    public void Configure(EntityTypeBuilder<Additional> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(64);
        
        builder.Property(x => x.Price)
            .HasColumnType("decimal(10,2)");
        
        builder.HasOne(x => x.Product)
            .WithMany(x => x.Additionals)
            .HasForeignKey(x => x.ProductId);
    }
}