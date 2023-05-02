using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Core.Models;

public class Product : EntityBase
{
    public Product(string name, string description, decimal price)
    {
        this.Id = Guid.NewGuid();
        this.Name = name;
        this.Description = description;
        this.Price = price;
    }
    public Product(Guid id, string name, string description, decimal price)
    {
        this.Id = id;
        this.Name = name;
        this.Description = description;
        this.Price = price;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}