using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Products.Models;

namespace Products.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed de Produtos
            builder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Produto 1", Price = 10.50m },
                new Product { Id = 2, Name = "Produto 2", Price = 20.00m },
                new Product { Id = 3, Name = "Produto 3", Price = 30.75m }
            );
        }
    }
}
