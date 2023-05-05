using WebStore.Core.Models;

namespace WebStore.API.Requests;

public class CreateProductRequest
{
    public CreateProductRequest(string name, string description, decimal price, string category)
    {
        Name = name;
        Description = description;
        Price = price;
        Category = category;
    }
    
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }

    public Product toProduct() {
        return new Product {
            Name=Name,
            Description=Description,
            Price=Price,
            Category=Category
        };
    }
}