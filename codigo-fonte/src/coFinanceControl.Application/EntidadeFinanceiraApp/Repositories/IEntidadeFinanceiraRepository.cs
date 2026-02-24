using CoFinanceControl.Domain.Models.EntidadeFinanceira;

namespace CoFinanceControl.Application.EntidadeFinanceiraApp.Repositories
{
    public interface IEntidadeFinanceiraRepository
    {
        //Analisando possibilidade de logica de exclusão no futuro
        Task AdicionarAsync(EntidadeFinanceira entidadeFinanceira, CancellationToken ct = default);
        Task<EntidadeFinanceira?> ObterPorIdAsync(Guid id, CancellationToken ct = default);
        Task AtualizarAsync(EntidadeFinanceira entidadeFinanceira, CancellationToken ct = default);
        Task InativarAsync(Guid id, CancellationToken ct = default);
    }
}