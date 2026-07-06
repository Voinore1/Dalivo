namespace Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string PhotoUrl { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Weight { get; set; }
    public decimal BasePrice { get; set; }

    public int CategoryId { get; set; }

    public ProductCategory Category { get; set; }
    public ICollection<ProductAdditional>? ProductAdditionals { get; set; }
    public ICollection<OrderProduct>? OrderProducts { get; set; }
    public ICollection<Additional>? Additionals { get; set; }
}