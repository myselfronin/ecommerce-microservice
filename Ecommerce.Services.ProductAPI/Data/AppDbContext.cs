using Ecommerce.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Ecommerce.Services.ProductAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Classic White T-Shirt",
                Price = 25,
                Description = "A timeless staple for any wardrobe, the classic white T-shirt is made from 100% soft cotton for maximum comfort. Perfect for casual wear or layering.<br/>Tailored fit with a crew neckline for a sleek look.",
                ImageUrl = "https://placehold.co/603x403",
                CategoryName = "Tops"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Denim Jeans",
                Price = 50,
                Description = "Our denim jeans feature a classic straight-leg cut with a hint of stretch for comfort. The deep indigo wash offers versatility for both casual and semi-formal looks.<br/>Five-pocket styling with a button closure and zip fly.",
                ImageUrl = "https://placehold.co/603x403",
                CategoryName = "Bottoms"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Leather Jacket",
                Price = 120,
                Description = "Crafted from premium genuine leather, this jacket is a symbol of timeless style. Features a zip front, stand-up collar, and quilted lining for warmth.<br/>Perfect for adding an edge to any outfit.",
                ImageUrl = "https://placehold.co/603x403",
                CategoryName = "Outerwear"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Cashmere Sweater",
                Price = 80,
                Description = "Luxuriously soft, this 100% cashmere sweater offers unparalleled comfort and warmth. The subtle ribbing at the cuffs, hem, and crew neck adds a touch of elegance.<br/>Ideal for layering during colder months.",
                ImageUrl = "https://placehold.co/603x403",
                CategoryName = "Knitwear"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Silk Scarf",
                Price = 35,
                Description = "Add a pop of color to your ensemble with our pure silk scarf. The lightweight, smooth fabric drapes beautifully and can be styled in various ways.<br/>Featuring an exclusive print for a unique touch.",
                ImageUrl = "https://placehold.co/603x403",
                CategoryName = "Accessories"
            });
        }
    }
}
