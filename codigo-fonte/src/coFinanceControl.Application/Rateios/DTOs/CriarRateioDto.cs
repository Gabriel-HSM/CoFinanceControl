using System.ComponentModel.DataAnnotations;

namespace CoFinanceControl.Application.Rateios.DTOs
{
    public sealed record class CriarRateioDto
    {
        public int CategoriaId { get; init; }
        [Required(ErrorMessage = "O destino da transação não pode ser vazia")]
        [MaxLength(20, ErrorMessage = "O destino deve ter no máximo 20 caracteres")]
        [MinLength(5, ErrorMessage = "O destino deve ter no mínimo 5 caracteres")]
        public required string Destino { get; init; }
        public decimal Valor { get; init; }
    }
}