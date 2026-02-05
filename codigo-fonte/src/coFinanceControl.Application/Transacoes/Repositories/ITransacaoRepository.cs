using CoFinanceControl.Domain.Models.Transacao;

namespace CoFinanceControl.Application.Transacoes.Repositories
{
    public interface ITransacaoRepository
    {
        Task AdicionarAsync (Transacao transacao, CancellationToken ct = default);
        Task<Transacao?> ObterPorIdAsync (int id, CancellationToken ct = default);
        Task AtualizarAsync (Transacao transacao, CancellationToken ct = default);
        Task<bool> DeletarAsync (int id, CancellationToken ct = default);
        Task<IEnumerable<Transacao>> ObterTodosAsync (CancellationToken ct = default);
    }
}