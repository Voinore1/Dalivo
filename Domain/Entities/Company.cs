namespace Domain.Entities;

public class Company
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string MainOfficePhoneNumber { get; set; } = null!;
    public string MainOfficeEmail { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string? WebsiteUrl { get; set; } = null!;

    public ICollection<Affiliate>? Affiliates { get; set; }
}