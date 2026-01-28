using CoFinanceControl.Domain.Models.Usuario;
using CoFinanceControl.Domain.Models.Usuario.ValueObects;
using Microsoft.EntityFrameworkCore;

namespace CoFinanceControl.Infrastructure.Data
{
    public class CoFinanceDbContext : DbContext
    {
        public CoFinanceDbContext(DbContextOptions<CoFinanceDbContext> options) : base(options)
        {
        }

        //Criação da tabela usuarios
        public DbSet<Usuario> Usuarios => Set<Usuario>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>(entity =>
            {
                //chave primaria
                entity.HasKey(u => u.Id);

                //tratamento de VOs
                entity.Property(u => u.Nome)
                    .HasConversion(
                        nome => nome.Valor,
                        valor => new PrimeiroNome(valor))
                    .HasMaxLength(100)
                    .IsRequired();

                entity.Property(u => u.Sobrenome)
                    .HasConversion(
                        sobrenome => sobrenome.Valor,
                        valor => new Sobrenome(valor))
                    .HasMaxLength(100)
                    .IsRequired();

                entity.Property(u => u.DataNascimento)
                    .HasConversion
                    (
                        data => data.HasValue ? data.Value.Valor : (DateOnly?)null,
                        valor => valor.HasValue ? new DataNascimento(valor.Value) : null);
                
                entity.Property(u => u.DataCriacao)
                .IsRequired();

                entity.Property(u => u.DataAtualizacao);

            });
        }
    }
}