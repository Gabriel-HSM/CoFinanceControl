using CoFinanceControl.Domain;

namespace CoFinanceControl.Application.Usuarios.Repository
{
    public interface IUsuarioRepository
    {
        Task<bool> ExistePorIdAsync(Guid usuarioId, CancellationToken cancellationToken = default);
        Task<bool> ExistePorCredencialIdAsync(Guid credencialId, CancellationToken cancellationToken = default);
        Task AdicionarAsync(Usuario usuario, CancellationToken cancellationToken = default);
        Task<Usuario?> ObterPorIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<Usuario?> ObterPorCredencialIdAsync(Guid credencialId, CancellationToken cancellationToken = default);
        Task<bool> AtualizarAsync(Usuario usuario, CancellationToken cancellationToken = default);
        Task<bool> RemoverAsync(Guid id, CancellationToken cancellationToken = default);
    }
}