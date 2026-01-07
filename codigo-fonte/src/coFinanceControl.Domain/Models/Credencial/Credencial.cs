using CoFinanceControl.Domain.Models.Credencial.ValueObjects;

namespace CoFinanceControl.Domain
{
    public class Credencial
    {
        public Guid Id { get; private set; }
        public Guid UsuarioId { get; private set; }
        public Email Email { get; private set; }
        public Senha Senha { get; private set; }
        public Usuario? Usuario { get; set; }

        private Credencial() { }

        public static Credencial Criar(Guid usuarioId, Email email, Senha senha)
        {
            return new Credencial
            {
                Id = Guid.NewGuid(),
                UsuarioId = usuarioId,
                Email = email,
                Senha = senha,
            };
        }

        public void AtualizarEmail(Email novoEmail)
        {
            Email = novoEmail;
        }

        public void AtualizarSenha(Senha senhaAntiga, Senha novaSenha)
        {
            if (Senha != senhaAntiga)
            {
                throw new InvalidOperationException("A senha antiga não corresponde.");
            }

            Senha = novaSenha;
        }

    }
}