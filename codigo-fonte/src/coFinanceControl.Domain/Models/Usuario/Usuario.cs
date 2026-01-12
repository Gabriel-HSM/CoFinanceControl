using CoFinanceControl.Domain.Enums;
using CoFinanceControl.Domain.Models.Credencial.ValueObjects;
using CoFinanceControl.Domain.Models.Usuario.ValueObjects;

namespace CoFinanceControl.Domain;

public class Usuario
{
    public Guid Id { get; private set; }
    public PrimeiroNome Nome { get; private set; }
    public Sobrenome Sobrenome { get; private set; }
    public DataNascimento? DataNascimento { get; private set; }
    public TipoPessoa TipoPessoa { get; private set; }
    public DateTime DataCriacao { get; private set; }
    public DateTime? DataAtualizacao { get; private set; }
    public Credencial? Credencial { get; private set; }
    public ICollection<Categoria> Categorias { get; private set; } = new List<Categoria>();

    private Usuario(){}

    //Usuario Guest, sem credencial e apenas testar o sistema
    public static Usuario CriarUsuario(PrimeiroNome nome, Sobrenome sobrenome, DataNascimento? dataNascimento, TipoPessoa tipoPessoa)
    {
        return new Usuario
        {
            Id = Guid.NewGuid(),
            Nome = nome,
            Sobrenome = sobrenome,
            DataNascimento = dataNascimento,
            TipoPessoa = tipoPessoa,
            DataCriacao = DateTime.UtcNow,
        };
    }

    //Duvida se preciso adicionar o guid do usuário pra que ele possa atualizar
    public void AtualizarUsuario(PrimeiroNome nome, Sobrenome sobrenome, DataNascimento? dataNascimento)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        DataNascimento = dataNascimento;
        DataAtualizacao = DateTime.UtcNow;
    }

    public void CriarCredencial(Email email, Senha senha)
    {
        if (Credencial is not null)
        {
            throw new InvalidOperationException("Já possui Conta");
        }

        Credencial = Credencial.CriarCredencial(Id, email, senha);
    }

}
