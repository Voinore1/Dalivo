namespace Domain.Entities;

public class Rating
{
    public int Id { get; set; }
    public int AffiliateRating { get; set; }
    public int CourierRating { get; set; }

    public int AffiliateId { get; set; }
    public int CourierId { get; set; }
    public int OrderId { get; set; }

    public Affiliate Affiliate { get; set; }
    public Courier Courier { get; set; }
    public Order Order { get; set; }
}