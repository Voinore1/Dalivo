using System.Reflection.PortableExecutable;

namespace Domain.Entities;

public class AffiliateBrake
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    public int WorkingDayId { get; set; }

    public AffiliateWorkingDay WorkingDay { get; set; }
}