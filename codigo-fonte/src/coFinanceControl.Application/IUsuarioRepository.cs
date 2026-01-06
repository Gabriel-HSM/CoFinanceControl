using CoFinanceControl.Domain;

namespace CoFinanceControl.Application
{
    public interface IUsuarioRepository
    {
        Task<Usuario> RegistrarAsync(Usuario usuario);
        Task<Usuario?> ObterPorIdAsync(Guid id);
        Task<Usuario?> AtualizarAsync(Usuario usuario);
        Task<bool> ExcluirAsync(Guid id);
        
    }
}