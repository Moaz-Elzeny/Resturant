using Microsoft.EntityFrameworkCore;

namespace Restaurant.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Item> items { get; set; }

        public DbSet<Order> orders { get; set; }

        public DbSet<Product> products { get; set; }
    }
}
