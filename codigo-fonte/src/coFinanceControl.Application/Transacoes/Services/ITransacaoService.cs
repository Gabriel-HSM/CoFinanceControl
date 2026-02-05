using CoFinanceControl.Application.Transacoes.DTOs;

namespace CoFinanceControl.Application.Transacoes.Services
{
    public interface ITransacaoService
    {
        public Task<TransacaoDto> CriarAsync (CriarTransacaoDto dto, CancellationToken ct = default);
        public Task<TransacaoDto?> ObterAsync (int id, CancellationToken ct = default);
        public Task<TransacaoDto> AtualizarAsync (int id, AtualizarTransacaoDto dto, CancellationToken ct = default);
        public Task<bool> DeletarAsync (int id, CancellationToken ct = default); 
        public Task<IEnumerable<TransacaoDto>> ObterTodosAsync (CancellationToken ct = default);
        
    }
}