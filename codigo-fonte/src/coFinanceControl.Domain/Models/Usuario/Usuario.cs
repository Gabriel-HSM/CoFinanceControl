using CoFinanceControl.Domain.Enums;
using CoFinanceControl.Domain.Models.Usuario.ValueObects;

namespace CoFinanceControl.Domain.Models.Usuario
{
    //sealed pra evitar herança e manter integridade.
    public sealed class Usuario
    {
        public Guid Id { get; private set; }
        public Guid EntidadeFinanceiraId { get; private set; }
        public PrimeiroNome Nome { get; private set; }
        public Sobrenome Sobrenome { get; private set; }
        public DataNascimento? DataNascimento { get; private set; }
        public Cargo Cargo { get; set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataAtualizacao { get; private set; }

        //Privado para garantir que o usuario seja criado apenas pelo método criar
        private Usuario(){}
        
        public static Usuario Criar(PrimeiroNome nome, Sobrenome sobrenome, DataNascimento? dataNascimento, Guid entidadeFinanceiraId, Cargo cargo)
        {
            return new Usuario
            {
                Id = Guid.NewGuid(),
                EntidadeFinanceiraId = entidadeFinanceiraId,
                Nome = nome,
                Sobrenome = sobrenome,
                Cargo = cargo,
                DataNascimento = dataNascimento,
                DataCriacao = DateTime.UtcNow
            };
        }
        
        public void Atualizar(PrimeiroNome nome, Sobrenome sobrenome, DataNascimento? dataNascimento, Cargo cargo)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cargo = cargo;
            DataNascimento = dataNascimento;
            DataAtualizacao = DateTime.UtcNow;
        }
    }
}