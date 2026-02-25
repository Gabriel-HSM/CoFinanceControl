using CoFinanceControl.Domain.Enums;
using CoFinanceControl.Domain.Models.EntidadeFinanceira.ValueObjects;
using UsuarioM = CoFinanceControl.Domain.Models.Usuario.Usuario;

namespace CoFinanceControl.Domain.Models.EntidadeFinanceira
{
    public sealed class EntidadeFinanceira
    {
        //Usuario pertence a ela
        public Guid Id { get; private set; } 
        public EntidadeNome Nome { get; private set; }
        //Solo, Familia ou Empresa
        public TipoEntidade TipoEntidade { get; private set; } 
        public DateTime DataCriacao { get; private set; } 
        public bool Ativo { get; private set; } 
        public DateTime? DataDesativacao { get; private set; } 
        public ICollection<UsuarioM> Usuarios { get; set; } = new List<UsuarioM>();

        private EntidadeFinanceira() {}

        public static EntidadeFinanceira Criar(EntidadeNome nome, TipoEntidade tipoConta)
        {
            return new EntidadeFinanceira
            {
                Id = Guid.NewGuid(),
                Nome = nome,
                TipoEntidade = tipoConta,
                DataCriacao = DateTime.UtcNow,
                Ativo = true
            };
        }
        public void  Atualizar(EntidadeNome nome)
        {
            Nome = nome;
        }

        public void Desativar()
        {
            Ativo = false;
            DataDesativacao = DateTime.UtcNow;
        }
        public void Reativar()
        {
            Ativo = true;
            DataDesativacao = null;
        }

        public void AdicionarUsuario(UsuarioM usuario)
        {
            if (TipoEntidade == TipoEntidade.Solo)
            {
                throw new ArgumentException("Não é possivel adicionar outros usuarios se a entidade for solo/pf");
            }

            Usuarios.Add(usuario);
        }
    }
}