using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class AffiliateConfiguration : IEntityTypeConfiguration<Affiliate>
{
    public void Configure(EntityTypeBuilder<Affiliate> builder)
    {
        builder.HasKey(e => e.Id);
        
        builder.HasOne(x => x.Company)
            .WithMany(x => x.Affiliates)
            .HasForeignKey(x => x.CompanyId);
    }
}