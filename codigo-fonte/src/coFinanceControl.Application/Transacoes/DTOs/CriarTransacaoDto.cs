using System.ComponentModel.DataAnnotations;
using CoFinanceControl.Application.Rateios.DTOs;

namespace CoFinanceControl.Application.Transacoes.DTOs
{
    public sealed record class CriarTransacaoDto
    {
        public Guid UsuarioId { get; init; }
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor deve ser maior que 0 e não deve ser vazio")]
        public decimal ValorTotal { get; init; }
        [Required(ErrorMessage = "A descrição da transação não pode ser vazia")]
        [MaxLength(155, ErrorMessage = "A descrição deve ter no máximo 155 caracteres")]
        [MinLength(5, ErrorMessage = "A descrição deve ter no mínimo 5 caracteres")]
        public required string Descricao { get; init; }
        [Required(ErrorMessage = "A transação deve ter uma categoria e destino (rateio).")]
        public required List<CriarRateioDto>? Rateios { get; init; }
    }
}