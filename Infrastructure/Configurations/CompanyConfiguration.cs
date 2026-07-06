using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Name)
            .HasMaxLength(64);
        
        builder.Property(e => e.Description)
            .HasMaxLength(512);
    }
}