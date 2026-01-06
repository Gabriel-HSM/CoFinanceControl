using CoFinanceControl.Domain;

// Possível adição de achar usuario por email

namespace CoFinanceControl.Application
{
    public interface ICredencialRepository
    {
        Task<Credencial> RegistrarEmailAsync(Guid idUsuario, string email);
        Task<Credencial> ObterPorIdAsync(Guid idUsuario);
        Task<Credencial> AtualizarEmailAsync(Guid idUsuario, string email);
        Task<bool> RemoverEmailAsync(Guid idUsuario, string email);
        Task<Credencial> RegistrarSenhaAsync(Guid idUsuario, string senha);
        Task<Credencial> AlterarSenhaAsync(Guid idUsuario, string senha, string novaSenha);
        
    }
}