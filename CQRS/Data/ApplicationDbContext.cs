using Microsoft.EntityFrameworkCore;
using CQRS.Models;

namespace CQRS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Sample Product 1", Price = 9.99m },
                new Product { Id = 2, Name = "Sample Product 2", Price = 19.99m },
                new Product { Id = 3, Name = "Sample Product 3", Price = 29.99m }
            );
        }
    }
}
