using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(x => x.Role)
            .HasConversion<int>()
            .IsRequired();;
        
        builder.HasOne(x => x.User)
            .WithMany(x => x.Employees)
            .HasForeignKey(x => x.UserId);
        
        builder.HasOne(x => x.Affiliate)
            .WithMany(x => x.Employees)
            .HasForeignKey(x => x.AffiliateId);
    }
}