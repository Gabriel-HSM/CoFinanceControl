namespace CoFinanceControl.Application
{
    public interface IUsuarioRepository
    {
        Task<Usuario?> RegistrarAsync(Usuario usuario);
        Task<Usuario?> ObterPorIdAsync(Guid id);
        Task<Usuario?> ObterPorEmailAsync(string email);
        
    }
}