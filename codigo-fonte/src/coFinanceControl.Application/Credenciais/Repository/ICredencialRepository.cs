using CoFinanceControl.Domain;

namespace CoFinanceControl.Application.Credenciais.Repository
{
    public interface ICredencialRepository
    {
        Task<bool> ExistePorEmailAsync(string email, CancellationToken cancellationToken = default);
        Task<bool> ExistePorIdCredencialAsync(Guid credencialId, CancellationToken cancellationToken = default);
        Task<Credencial?> ObterPorEmailAsync(string email, CancellationToken cancellationToken = default);
        Task<Credencial?> ObterPorIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task AdicionarAsync(Credencial credencial, CancellationToken cancellationToken = default);
        Task AtualizarAsync(Credencial credencial, CancellationToken cancellationToken = default);
        Task<bool> RemoverAsync(Credencial credencial, CancellationToken cancellationToken = default);
    }
}