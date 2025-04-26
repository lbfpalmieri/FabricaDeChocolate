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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Embalagem>().HasData(
                new Embalagem
                {
                    Id = 1,
                    Tamanho = "4x8",
                    Cor = "Amarelo",
                    QtdDisponivel = 200,
                    QtdMinima = 100
                },
                new Embalagem
                {
                    Id = 2,
                    Tamanho = "5x10",
                    Cor = "Azul",
                    QtdDisponivel = 430,
                    QtdMinima = 100
                }
            );
        }
    }
}
