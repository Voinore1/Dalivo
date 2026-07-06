using Domain.Enums;

namespace Domain.Entities;

public class Order
{
    public int Id { get; set; }
    public string? CustomerAddress { get; set; }
    public string? CustomerCoordinates { get; set; }
    public decimal ProductPrice { get; set; }
    public decimal DeliveryPrice { get; set; }
    public decimal ServiceFee { get; set; }
    public decimal Tip { get; set; }
    public OrderStatus Status { get; set; }
    public string? OtherReceiverName { get; set; }
    public string? OtherReceiverPhone { get; set; }
    public DateTime CreatedAt { get; set; } =  DateTime.UtcNow;
    public DateTime CookedAt { get; set; }
    public DateTime DeliveryStart { get; set; }
    public DateTime DeliveryEnd { get; set; }

    public int CourierId { get; set; }
    public int CustomerId { get; set; }
    public int AffiliateId { get; set; }

    public Courier Courier { get; set; }
    public User Customer { get; set; }
    public Affiliate Affiliate { get; set; }
    public Rating? Rating { get; set; }
    public ICollection<OrderProduct>? OrderProducts { get; set; }
}