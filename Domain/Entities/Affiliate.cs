namespace Domain.Entities;

public class Affiliate
{
    public int Id { get; set; }
    public string City { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string? WebsiteUrl { get; set; } = null!;
    
    public int ManagerId { get; set; }
    public int CompanyId { get; set; }

    public User Manager { get; set; }
    public Company Company { get; set; }
    public ICollection<AffiliateWorkingDay>? WorkingDays { get; set; }
    public ICollection<Employee>? Employees { get; set; }
    public ICollection<ProductCategory>? ProductCategories { get; set; }
    public ICollection<Order>? Orders { get; set; }
    public ICollection<Rating>? Ratings { get; set; }
}