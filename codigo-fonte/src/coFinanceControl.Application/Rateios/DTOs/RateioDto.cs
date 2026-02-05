namespace CoFinanceControl.Application.Rateios.DTOs
{
    public sealed record class RateioDto
    {
        public int CategoriaId { get; init; }
        public required string Destino { get; init; }
        public decimal Valor { get; init; }
    }
}