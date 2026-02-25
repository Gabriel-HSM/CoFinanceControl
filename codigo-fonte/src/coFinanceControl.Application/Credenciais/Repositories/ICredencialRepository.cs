using CoFinanceControl.Domain.Models.Credencial;

namespace CoFinanceControl.Application.Credenciais.Repositories
{
    public interface ICredencialRepository
    {
        Task AdicionarAsync(Credencial credencial, CancellationToken ct = default);
        Task<bool> ExisteComEmailAsync(string email, CancellationToken ct = default);
        Task<Credencial?> ObterPorEmailAsync(string email, CancellationToken ct = default);
        Task AtualizarAsync(Credencial credencial, CancellationToken ct = default);
    }
}