﻿using Microsoft.EntityFrameworkCore;

namespace Mango.Services.Product.DbContexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Models.Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Models.Product>().HasData(new Models.Product
        {
            ProductId = 1,
            Name = "Samosa",
            Price = 15,
            Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
            ImageUrl = "",
            CategoryName = "Appetizer"
        });
        modelBuilder.Entity<Models.Product>().HasData(new Models.Product
        {
            ProductId = 2,
            Name = "Paneer Tikka",
            Price = 13.99,
            Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
            ImageUrl = "",
            CategoryName = "Appetizer"
        });
        modelBuilder.Entity<Models.Product>().HasData(new Models.Product
        {
            ProductId = 3,
            Name = "Sweet Pie",
            Price = 10.99,
            Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
            ImageUrl = "",
            CategoryName = "Dessert"
        });
        modelBuilder.Entity<Models.Product>().HasData(new Models.Product
        {
            ProductId = 4,
            Name = "Pav Bhaji",
            Price = 15,
            Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
            ImageUrl = "",
            CategoryName = "Entree"
        });
    }
}