using Microsoft.EntityFrameworkCore;
using WebStore.Core.Models;

namespace WebStore.Database;

public class WebStoreContext : DbContext
{
    public WebStoreContext(DbContextOptions options) : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=webstore.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(new Product {
            Name = "Dry Food",
            Description = "Premium, delicious, kibble made from free range, grass-fed horses. 1 kilogram of kibble.",
            Price = 12.34m,
            Category = "food"
        });
        modelBuilder.Entity<Product>().HasData(new Product {
            Name = "Wet Food",
            Description = "Hearty, chunky, pieces of 84% mercury-free tuna. 1 kilogram of wet food.",
            Price = 23.45m,
            Category = "food"
        });
        modelBuilder.Entity<Product>().HasData(new Product {
            Name = "Superpremium Wet Food",
            Description = "It's rainbows and unicorns with our most luxury wet food - literally! Made from 100% queer horse/narwhal hybrids. 1 kilogram of wet food.",
            Price = 34.56m,
            Category = "food"
        });
        modelBuilder.Entity<Product>().HasData(new Product {
            Name = "Legacy™ Cat Food Bowl",
            Description = "Have your cat eat in style out of this 100% titanium Legacy™ branded food bowl!",
            Price = 45.67m,
            Category = "accessories"
        });
        modelBuilder.Entity<Product>().HasData(new Product {
            Name = "Legacy™ Automated Cat Feeder",
            Description = "Have your cat bother the robot instead of you in the morning! Connect the Legacy™ Automated Cat Feeder to your stupid home IoT network for extra functionality. Singularity kill-switch sold separately.",
            Price = 56.78m,
            Category = "accessories"
        });
        modelBuilder.Entity<Product>().HasData(new Product {
            Name = "Beigies™ Rodent-Shaped Dental Treats",
            Description = "Say \"no\" to painful teeth cleanings, and \"Yes!\" to Beigies™ feline dental treats! Pack of 24.",
            Price = 67.89m,
            Category = "medical"
        });
    }
}