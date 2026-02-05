using CoFinanceControl.Application.Rateios.DTOs;

namespace CoFinanceControl.Application.Transacoes.DTOs
{
    public sealed record class TransacaoDto
    {
        public int Id { get; init; }
        public Guid UsuarioId { get; init; }
        public decimal ValorTotal { get; init; }
        public required string Descricao { get; init; }
        public DateTime DataCriacao { get; init; }
        public DateTime DataAtualizacao { get; init; }
        public required List<RateioDto> Rateios { get; init; }
    }
}