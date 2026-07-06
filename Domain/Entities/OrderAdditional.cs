namespace Domain.Entities;

public class OrderAdditional
{
    public int Id { get; set; }
    public int Quantity { get; set; }

    public int AdditionalId { get; set; }
    public int OrderProductId { get; set; }
    
    public OrderProduct OrderProduct { get; set; }
    public Additional Additional { get; set; }
}