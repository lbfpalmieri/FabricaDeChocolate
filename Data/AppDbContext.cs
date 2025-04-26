using Microsoft.EntityFrameworkCore;

namespace FabricaDeChocolate.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Embalagem> Embalagens { get; set; }
        public DbSet<Trufa> Trufas { get; set; }
    }
}
