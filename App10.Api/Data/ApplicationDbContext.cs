using App10.Api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App10.Api.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            for (var i = 1; i <= 10; i++)
            {
                modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = i,
                        Name = $"Product {i}",
                        Category = $"Category {(i % 3) + 1}",
                        Tag = $"Tag {(i % 3) + 1}",
                        Price = 1000.00 + ((i % 3) + 1),
                        Description = $"Description for Product {i}",
                        Image = $"product-{i}.jpg"
                    }
                );
            }
        }
    }
}
