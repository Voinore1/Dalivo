using Domain.Enums;

namespace Domain.Entities;

public class Employee
{
    public int Id { get; set; }
    public EmployeeRoles Role { get; set; }

    public int UserId { get; set; }
    public int AffiliateId { get; set; }
    
    public User User { get; set; }
    public Affiliate Affiliate { get; set; }
}