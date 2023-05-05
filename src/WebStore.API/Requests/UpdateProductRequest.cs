using WebStore.Core.Models;

namespace WebStore.API.Requests;

public class UpdateProductRequest
{
    public UpdateProductRequest(Guid id, string name, string description, decimal price, string category)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        Category = category;
    }
    
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    
    public Product toProduct() {
        return new Product(Id) {
            Name=Name,
            Description=Description,
            Price=Price,
            Category=Category
        };
    }
}