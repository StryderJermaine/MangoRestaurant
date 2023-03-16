using Microsoft.EntityFrameworkCore;

namespace Mango.Services.Product.DbContexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Models.Product> Products { get; set; }
}