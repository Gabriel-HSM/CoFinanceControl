namespace CoFinanceControl.Domain;

public class Usuario
{
    public Guid Id { get; set; }
    public required string Nome { get; set; }
    public required DateTime DataNascimento { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataAtualizacao { get; set; }
    public Credencial? Credencial { get; set; } //possivel mudança futura

    public ICollection<Categoria> Categorias { get; set; } = new List<Categoria>();


}
