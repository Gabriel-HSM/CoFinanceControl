namespace CoFinanceControl.Application.Rateios.DTOs
{
    public sealed record class CriarRateioDto
    {
        public int CategoriaId { get; init; }
        public required string Destino { get; init; }
        public decimal Valor { get; init; }
    }
}