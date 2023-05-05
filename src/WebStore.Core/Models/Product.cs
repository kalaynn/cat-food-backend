using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Core.Models;

public class Product : EntityBase
{
    public Product()
    {
        this.Id = Guid.NewGuid();
    }
    public Product(Guid id)
    {
        this.Id = id;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
}