using Domain.Enums;

namespace Domain.Entities;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public bool IsEmailConfirmed { get; set; }
    public string PasswordHash { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string? PhotoUrl { get; set; }
    public UserRoles Role { get; set; }

    public ICollection<Affiliate>? AffiliateManagers { get; set; }
    public ICollection<Employee>? Employees { get; set; }
    public ICollection<Courier>? Couriers { get; set; }
    public ICollection<Order>? CustomerOrders { get; set; }
}