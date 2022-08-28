using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using onlineShopping.Models;

namespace onlineShopping.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ):base(options)
        {
        }

        public DbSet<Category> category { get; set; }
        public DbSet<Mark> mark { get; set; }
        public DbSet<Size> size { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<Color> color { get; set; }
        public DbSet<Basket> basket { get; set; }
        public DbSet<Message> message { get; set; }
        public DbSet<RegisterStart> registerStart { get; set; }

    }
}
