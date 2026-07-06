using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.IsEmailConfirmed)
            .HasDefaultValue(false);
        
        builder.HasIndex(e => e.Email).IsUnique();
        builder.HasIndex(e => e.PhoneNumber).IsUnique();
        
        builder.Property(e => e.FirstName)
            .HasMaxLength(32);
        
        builder.Property(e => e.LastName)
            .HasMaxLength(32);

        builder.Property(e => e.Role)
            .HasConversion<int>();
    }
}