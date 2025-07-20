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
                var index = ((i - 1) % 3) + 1;

                modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = i,
                        Name = $"Product {i}",
                        Category = $"Category {index}",
                        Tag = $"Tag {index}",
                        Price = 1000.0 * index,
                        Description = $"Description for Product {i}",
                        Image = $"images/{i}.jpg"
                    }
                );
            }
        }
    }
}
