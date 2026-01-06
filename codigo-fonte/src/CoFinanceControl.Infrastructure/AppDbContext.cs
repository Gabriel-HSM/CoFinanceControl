using CoFinanceControl.Domain;
using Microsoft.EntityFrameworkCore;


namespace CoFinanceControl.Infrastructure;

public class AppDbContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Credencial> Credenciais { get; set; }
    public DbSet<Categoria> Categorias { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(e =>
        {
            e.ToTable("Usuarios");
            e.HasKey(u => u.Id);
            e.Property(u => u.Nome).IsRequired().HasMaxLength(255);
            e.Property(u => u.DataNascimento).HasColumnName("data_nascimento").IsRequired();
            e.Property(u => u.DataCriacao).HasColumnName("data_criacao");
            e.Property(u => u.DataAtualizacao).HasColumnName("data_atualizacao");


            e.HasOne(x => x.Credencial)
            .WithOne(x => x.Usuario)
            .HasForeignKey<Credencial>(c => c.UsuarioId)
            .OnDelete(DeleteBehavior.Cascade);

            e.HasMany(c => c.Categorias)
            .WithOne(c => c.Usuario)
            .HasForeignKey(c => c.UsuarioId)
            .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Credencial>(e =>
        {
            e.ToTable("Credenciais");
            e.HasKey(c => c.Id);
            e.HasIndex(u => u.UsuarioId).IsUnique();
            e.HasIndex(c => c.Email).IsUnique(); //evitar duplicação de email
            e.Property(c => c.UsuarioId).HasColumnName("usuario_id").IsRequired();
            e.Property(c => c.Senha).HasColumnName("senha").IsRequired();
            e.Property(c => c.Email).HasColumnName("email").IsRequired().HasMaxLength(100);
        });

        modelBuilder.Entity<Categoria>(e =>
        {
            e.ToTable("Categorias");
            e.HasKey(c => c.Id);
            e.Property(c => c.UsuarioId).HasColumnName("usuario_id").IsRequired();
            e.Property(c => c.Nome).HasColumnName("nome_categoria").IsRequired().HasMaxLength(50);
            e.Property(c => c.DataCriacao).HasColumnName("data_criacao");
            e.Property(c => c.DataAtualizacao).HasColumnName("data_atualizacao");
        });
    }
        
}
