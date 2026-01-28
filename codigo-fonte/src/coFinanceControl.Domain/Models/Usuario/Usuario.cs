using CoFinanceControl.Domain.Models.Usuario.ValueObects;

namespace CoFinanceControl.Domain.Models.Usuario
{
    //sealed pra evitar herança e manter integridade.
    public sealed class Usuario
    {
        public Guid Id { get; private set; }
        public PrimeiroNome Nome { get; private set; }
        public Sobrenome Sobrenome { get; private set; }
        public DataNascimento? DataNascimento { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataAtualizacao { get; private set; }

        //Privado para garantir que o usuario seja criado apenas pelo método criar
        private Usuario(){}
        
        public static Usuario Criar(PrimeiroNome nome, Sobrenome sobrenome, DataNascimento? dataNascimento)
        {
            return new Usuario
            {
                Id = Guid.NewGuid(),
                Nome = nome,
                Sobrenome = sobrenome,
                DataNascimento = dataNascimento,
                DataCriacao = DateTime.UtcNow
            };
        }
        
        public void Atualizar(PrimeiroNome nome, Sobrenome sobrenome, DataNascimento? dataNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            DataAtualizacao = DateTime.UtcNow;
        }
    }
}