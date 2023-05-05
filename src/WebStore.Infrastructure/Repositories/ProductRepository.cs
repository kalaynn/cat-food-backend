using WebStore.Core.Models;
using WebStore.Database;

namespace WebStore.Infrastructure.Repositories;

public class ProductRepository : Repository<Product>
{
    public ProductRepository(WebStoreContext dbContext) : base(dbContext)
    {
    }
}