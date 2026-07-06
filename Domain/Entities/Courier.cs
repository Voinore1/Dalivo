namespace Domain.Entities;

public class Courier
{
    public int Id { get; set; }
    public decimal Balance { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int UserId { get; set; }
    
    public User User { get; set; }
    public ICollection<Order>? Orders { get; set; }
    public ICollection<Rating>? Ratings { get; set; }
}