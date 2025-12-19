using Microsoft.EntityFrameworkCore;
using ControleFinanceiro.Domain.Entities;

namespace ControleFinanceiro.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Transacao> Transacoes => Set<Transacao>();
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transacao>(entity =>
            {
                entity.ToTable("Transacoes");

                entity.HasKey(t => t.Id);

                entity.Property(t => t.Tipo).IsRequired().HasMaxLength(10);

                entity.Property(t => t.Valor).IsRequired().HasPrecision(15,2);
                entity.Property(t => t.Descricao).IsRequired().HasMaxLength(255);
            });
        }
    }
}