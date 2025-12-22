using ControleFinanceiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<Credencial> Credenciais {get; set;}
        public DbSet<Categoria> Categorias {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //1:1
            modelBuilder.Entity<Credencial>()
            .HasOne(coluna => coluna.Usuario)
            .WithOne(coluna => coluna.Credencial)
            .HasForeignKey<Credencial>(c => c.IdUsuario )
            .HasConstraintName("FK_Credencial_Usuario");

            //1:N
            modelBuilder.Entity<Usuario>()
            .HasMany(c => c.Categorias)
            .WithOne(c => c.Usuario)
            .HasForeignKey(c => c.IdUsuario)
            .HasConstraintName("FK_Categoria_Usuario");

            //N:N
            // modelBuilder.Entity<NÃOIMPORTAORDEMPOISATABELAINTERMEDIÁRIAQUEARMAZENA>()
            // .HasMany(c => c.tabela1)
            // .WithMany(c => c.tabela2)
            // .UsingEntity<TabelaIntermediaria>(
            //     //tabela1id
            //     c => c.HasOne(c => c.tabela1)
            //     .WithMany()
            //     .HasForeignKey(c => c.IdTabela1)
            //     .HasConstraintName("Fk_NOME_tabela1"),
            //     //tabela2id
            //     e => e.HasOne(e => e.tabela2)
            //     .WithMany()
            //     .HasForeignKey(e => e.Idtabela2)
            //     .HasConstraintName("Fk_Nome_tabela2")

            // c =>
            // {
            //     c.HasKey(r => new {r.Idusuario, r.IdCurso});

            //     c.ToTable("NOME");

            //     c.HasIndex(r => r.IdCurso)
            //     .hasDatabaseName("IX_UsuarioCursi_idCurso");

            //     c.HasIndex(r => r.IdUsuario)
            //     .hasDatabaseName("IX_UsuarioCursi_idUsuario");
            // }

            // );

        }
    }
}