using CoFinanceControl.Domain.Enums;
using CoFinanceControl.Domain.Models.Usuario.ValueObjects;

namespace CoFinanceControl.Domain;

public class Usuario
{
    public Guid Id { get; private set; }
    public PrimeiroNome Nome { get; private set; }
    public Sobrenome Sobrenome { get; private set; }
    public DataNascimento DataNascimento { get; private set; }
    public TipoPessoa TipoPessoa { get; private set; }
    public DateTime DataCriacao { get; private set; }
    public DateTime DataAtualizacao { get; private set; }
    public Credencial? Credencial { get; private set; } //possivel mudança futura

    public ICollection<Categoria> Categorias { get; private set; } = new List<Categoria>();

    private Usuario(){}


}
