using Microsoft.EntityFrameworkCore;

namespace WineShopApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Wine> Wines { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
