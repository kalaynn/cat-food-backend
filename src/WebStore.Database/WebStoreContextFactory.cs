using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WebStore.Database;

public class WebStoreContextFactory : IDesignTimeDbContextFactory<WebStoreContext>
{
    public WebStoreContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<WebStoreContext>();
        optionsBuilder.UseSqlite("Data Source=webstore.db");

        return new WebStoreContext(optionsBuilder.Options);
    }
}