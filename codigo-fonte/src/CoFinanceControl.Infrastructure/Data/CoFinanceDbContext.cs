using CoFinanceControl.Domain.Models.Categoria;
using CoFinanceControl.Domain.Models.Categoria.ValueObjects;
using CoFinanceControl.Domain.Models.Rateios;
using CoFinanceControl.Domain.Models.Transacao;
using CoFinanceControl.Domain.Models.Transacao.ValueObjects;
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

        //Criação das tabelas
        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<Categoria> Categorias => Set<Categoria>();
        public DbSet<Transacao> Transacoes => Set<Transacao>();
        public DbSet<Rateio> Rateios => Set<Rateio>();


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

            //Categoria

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.HasOne<Usuario>()
                .WithMany()
                .HasForeignKey(c => c.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict)//Impede que exclua caso usuario tenha categorias
                .IsRequired(false); //permite nulo

                entity.Property(c => c.Nome)
                .HasConversion(
                    nome => nome.Valor,
                    valor => new CategoriaNome(valor))
                .HasMaxLength(100)
                .IsRequired();

                entity.Property(c => c.Descricao)
                .HasConversion(
                    descricao => descricao.Valor,
                    valor => new CategoriaDescricao(valor))
                .HasMaxLength(255)
                .IsRequired();

                entity.Property(c => c.isSistema)
                .IsRequired()
                .HasDefaultValue(false);

                entity.Property(c => c.Icone)
                .HasMaxLength(60);

                entity.Property(c => c.DataCriacao)
                .IsRequired();

                entity.Property(c => c.DataAtualizacao);

                entity.HasIndex(c => c.UsuarioId);
                
            });

            //Transação

            modelBuilder.Entity<Transacao>(entity =>
            {
                entity.HasKey(t => t.Id);

                entity.HasOne<Usuario>()
                .WithMany()
                .HasForeignKey(t => t.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

                entity.Property(t => t.ValorTotal)
                .HasConversion(
                    valorTotal => valorTotal.Valor,
                    valor => new TransacaoValor(valor))
                .HasColumnType("decimal(18,2)")
                .IsRequired();

                entity.Property(t => t.Descricao)
                .HasConversion(
                    descricao => descricao.Valor,
                    valor => new TransacaoDescricao(valor))
                .HasMaxLength(155)
                .IsRequired();

                entity.Property(t => t.DataCriacao)
                .IsRequired();

                entity.Property(t => t.DataAtualizacao);

                entity.HasMany<Rateio>()
                .WithOne()
                .HasForeignKey(r => r.TransacaoId)
                .OnDelete(DeleteBehavior.Cascade);
            });

            //Rateios

            modelBuilder.Entity<Rateio>(entity =>
            {
                entity.HasKey(r => r.Id);

                entity.Property(r => r.TransacaoId)
                .IsRequired();

                entity.Property(r => r.CategoriaId)
                .IsRequired();

                entity.Property(r => r.Valor)
                .HasConversion(
                    valorR => valorR.Valor,
                    valor => new ValorRateio(valor))
                .HasColumnType("decimal(18,2)")
                .IsRequired();

                entity.HasIndex(r => r.TransacaoId);
                entity.HasIndex(r => r.CategoriaId);
            });
        }
    }
}