namespace Domain.Entities;

public class ProductCategory
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public int AffiliateId { get; set; }
    public int? ProductCategoryId { get; set; }

    public Affiliate Affiliate { get; set; }
    public ProductCategory? Category { get; set; }

    public ICollection<ProductCategory>? ProductCategories { get; set; }
    public ICollection<Product>? Products { get; set; }
}