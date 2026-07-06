using Domain.Enums;

namespace Domain.Entities;

public class AffiliateWorkingDay
{
    public int Id { get; set; }
    public Days Day  { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    public int AffiliateId { get; set; }

    public Affiliate Affiliate { get; set; }
    public ICollection<AffiliateBrake>? Brakes { get; set; }
}