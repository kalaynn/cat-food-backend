using WebStore.Core.Models;

namespace WebStore.API.Requests;

public class UpdateProductRequest
{
    public UpdateProductRequest(Guid id, string name, string description, decimal price)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
    }
    
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    
    public Product toProduct() {
        return new Product(
            Id,
            Name,
            Description,
            Price
        );
    }
}