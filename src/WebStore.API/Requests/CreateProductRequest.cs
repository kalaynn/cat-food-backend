using WebStore.Core.Models;

namespace WebStore.API.Requests;

public class CreateProductRequest
{
    public CreateProductRequest(string name, string description, decimal price)
    {
        Name = name;
        Description = description;
        Price = price;
    }
    
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    public Product toProduct() {
        return new Product(
            Name,
            Description,
            Price
        );
    }
}