using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class RatingConfiguration : IEntityTypeConfiguration<Rating>
{
    public void Configure(EntityTypeBuilder<Rating> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.HasOne(x => x.Courier)
            .WithMany(x => x.Ratings)
            .HasForeignKey(x => x.CourierId);
        
        builder.HasOne(x => x.Affiliate)
            .WithMany(x => x.Ratings)
            .HasForeignKey(x => x.AffiliateId);
    }
}