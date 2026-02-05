using CoFinanceControl.Application.Rateios.DTOs;

namespace CoFinanceControl.Application.Transacoes.DTOs
{
    public sealed record class AtualizarTransacaoDto
    {
        public decimal? ValorTotal { get; init; }
        public string? Descricao { get; init; }
        public required List<CriarRateioDto> Rateios { get; init; }
    }
}