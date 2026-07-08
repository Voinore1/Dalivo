using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext() {}
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    
    DbSet<Additional> Additionals { get; set; }
    DbSet<Affiliate> Affiliates { get; set; }
    DbSet<AffiliateBrake> AffiliateBrakes { get; set; }
    DbSet<AffiliateWorkingDay> AffiliateWorkingDays { get; set; }
    DbSet<Company> Companies { get; set; }
    DbSet<Courier> Couriers { get; set; }
    DbSet<Employee> Employees { get; set; }
    DbSet<Order> Orders { get; set; }
    DbSet<OrderAdditional> OrderAdditionals { get; set; }
    DbSet<OrderProduct> OrderProducts { get; set; }
    DbSet<Product> Products { get; set; }
    DbSet<ProductCategory> ProductCategories { get; set; }
    DbSet<Rating> Ratings { get; set; } 
    DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}