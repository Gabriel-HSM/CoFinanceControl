using CoFinanceControl.Application.Rateios.DTOs;

namespace CoFinanceControl.Application.Transacoes.DTOs
{
    public sealed record class CriarTransacaoDto
    {
        public Guid UsuarioId { get; init; }
        public decimal ValorTotal { get; init; }
        public required string Descricao { get; init; }
        public required List<CriarRateioDto> Rateios { get; init; }
    }
}