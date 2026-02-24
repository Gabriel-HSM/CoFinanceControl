using CoFinanceControl.Domain.Enums;
using CoFinanceControl.Domain.Models.Credencial.ValueObjects;

namespace CoFinanceControl.Domain.Models.Credencial
{
    public sealed class Credencial
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public required Email Email { get; set; }
        public Senha? SenhaHash { get; set; } // (Google não usa senha)
        public ResponsavelAutenticacao ResponsavelAutenticacao { get; set; }
        public string? ResponsavelAutenticacaoId { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }

        private Credencial(){}

        public static Credencial CriarComEmailSenha(Guid usuarioId, Email email, Senha senhaHash)
        {
            return new Credencial
            {
                UsuarioId = usuarioId,
                Email = email,
                SenhaHash = senhaHash,
                ResponsavelAutenticacao = ResponsavelAutenticacao.EmailSenha,
                DataCriacao = DateTime.UtcNow
            };
        }

        public static Credencial CriarOAuth(Guid usuarioId, Email email, ResponsavelAutenticacao responsavel, string responsavelId)
        {
            return new Credencial
            {
                UsuarioId = usuarioId,
                Email = email,
                ResponsavelAutenticacao = responsavel,
                ResponsavelAutenticacaoId = responsavelId,
                DataCriacao = DateTime.UtcNow
            };
        }

        public void Atualizar(Email email, Senha? senhaHash = null)
        {
            Email = email;
            if (senhaHash != null && ResponsavelAutenticacao == ResponsavelAutenticacao.EmailSenha)
            {
                SenhaHash = senhaHash;
            }
            DataAtualizacao = DateTime.UtcNow;
        }
        
    }
}