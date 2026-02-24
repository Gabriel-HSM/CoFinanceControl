using CoFinanceControl.Application.EntidadeFinanceiraApp.DTOs;

namespace CoFinanceControl.Application.EntidadeFinanceiraApp.Services
{
    public interface IEntidadeFinanceiraService
    {
        Task<EntidadeFinanceiraDto> ObterAsync(CancellationToken ct = default);
        Task<EntidadeFinanceiraDto?> AtualizarAsync(Guid id, AtualizarEntidadeDto dto, CancellationToken ct = default);
        Task<bool> InativarAsync(Guid id, CancellationToken ct = default);
    }
}