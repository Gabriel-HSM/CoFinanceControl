using CoFinanceControl.Domain.Models.Credencial.ValueObjects;

namespace CoFinanceControl.Domain.Models.Credencial
{
    public sealed class Credencial
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public required Email Email { get; set; }
        public required Senha SenhaHash { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        //Possibilidade de conta google no futuro

        private Credencial(){}

        public static Credencial Criar(Guid id, Guid usuarioId, Email email, Senha senhaHash)
        {
            return new Credencial
            {
                Id = id,
                UsuarioId = usuarioId,
                Email = email,
                SenhaHash = senhaHash,
                DataCriacao = DateTime.UtcNow
            };
        }

        public void Atualizar(Email email, Senha senhaHash)
        {
            Email = email;
            SenhaHash = senhaHash;
        }
        
    }
}