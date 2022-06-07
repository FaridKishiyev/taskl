using fiorello.Models;
using Microsoft.EntityFrameworkCore;

namespace fiorello.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Flowers> Flowers { get; set; }
    }
}
