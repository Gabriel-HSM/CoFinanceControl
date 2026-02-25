using CoFinanceControl.Domain.Models.Categoria;
using CoFinanceControl.Domain.Models.Categoria.ValueObjects;
using CoFinanceControl.Domain.Models.Credencial;
using CoFinanceControl.Domain.Models.Credencial.ValueObjects;
using CoFinanceControl.Domain.Models.EntidadeFinanceira;
using CoFinanceControl.Domain.Models.EntidadeFinanceira.ValueObjects;
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
        public DbSet<EntidadeFinanceira> EntidadesFinanceiras => Set<EntidadeFinanceira>();
        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<Credencial> Credenciais => Set<Credencial>();
        public DbSet<Categoria> Categorias => Set<Categoria>();
        public DbSet<Transacao> Transacoes => Set<Transacao>();
        public DbSet<Rateio> Rateios => Set<Rateio>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EntidadeFinanceira>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Nome)
                    .HasConversion(
                        nome => nome.Valor,
                        valor => new EntidadeNome(valor))
                    .HasMaxLength(100)
                    .IsRequired();

                entity.Property(e => e.TipoEntidade)
                    .HasConversion<int>()
                    .IsRequired();

                entity.Property(e => e.DataCriacao)
                    .IsRequired();

                entity.Property(e => e.Ativo)
                    .IsRequired();

                entity.Property(e => e.DataDesativacao);
            });

            //Usuarios

            modelBuilder.Entity<Usuario>(entity =>
            {
                //chave primaria
                entity.HasKey(u => u.Id);

                entity.HasOne<EntidadeFinanceira>()
                    .WithMany(e => e.Usuarios)
                    .HasForeignKey(u => u.EntidadeFinanceiraId)
                    .OnDelete(DeleteBehavior.Restrict);

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

                entity.HasIndex(u => u.EntidadeFinanceiraId);

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
                entity.HasIndex(c => c.Nome).IsUnique();
                
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

                entity.Property(r => r.Destino)
                .HasConversion(
                    destino => destino.Valor,
                    valor => new DestinoRateio(valor))
                .HasMaxLength(100)
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

            //Credencial

            modelBuilder.Entity<Credencial>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.HasOne<Usuario>()
                    .WithOne()
                    .HasForeignKey<Credencial>(c => c.UsuarioId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.Property(c => c.Email)
                    .HasConversion(
                        email => email.Valor,
                        valor => new Email(valor))
                    .HasMaxLength(255)
                    .IsRequired();

                entity.Property(c => c.SenhaHash)
                    .HasConversion(
                        senha => senha.HasValue ? senha.Value.Valor : null,
                        valor => valor != null ? Senha.DeHash(valor) : (Senha?)null)
                    .HasMaxLength(255);

                entity.Property(c => c.ResponsavelAutenticacao)
                    .HasConversion<int>()
                    .IsRequired();

                entity.Property(c => c.ResponsavelAutenticacaoId)
                    .HasMaxLength(255);

                entity.Property(c => c.DataCriacao)
                    .IsRequired();

                entity.Property(c => c.DataAtualizacao);

                entity.HasIndex(c => c.Email).IsUnique();
                entity.HasIndex(c => c.UsuarioId).IsUnique();
            });
        }
    }
}