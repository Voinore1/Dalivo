namespace Domain.Entities;

public class ProductAdditional
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int MaxQuantity { get; set; }
    public decimal Price { get; set; }

    public int ProductId { get; set; }

    public Product Product { get; set; }
}