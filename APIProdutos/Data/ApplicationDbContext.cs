using Microsoft.EntityFrameworkCore;
using APIProdutos.Models;

namespace APIProdutos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) :
            base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasKey(p => p.CodigoBarras);
            modelBuilder.Entity<Usuario>()
                .HasKey(p => p.ID);
        }
    }
}