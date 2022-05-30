using Microsoft.EntityFrameworkCore;
using Flowers.Models;

namespace Flowers.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Flower> FlowerCard { get; set; }
        public DbSet<FlowerCategory> Category { get; set; }
    }

   
}
