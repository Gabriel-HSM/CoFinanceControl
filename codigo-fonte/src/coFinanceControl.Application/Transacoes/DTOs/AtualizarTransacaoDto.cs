using System.ComponentModel.DataAnnotations;
using CoFinanceControl.Application.Rateios.DTOs;

namespace CoFinanceControl.Application.Transacoes.DTOs
{
    public sealed record class AtualizarTransacaoDto
    {
        public decimal? ValorTotal { get; init; }
        [MaxLength(155, ErrorMessage = "A descrição deve ter no máximo 155 caracteres")]
        public string? Descricao { get; init; }
        [Required(ErrorMessage = "A transação deve ter no mínimo uma categoria e destino (rateio)")]
        public List<CriarRateioDto>? Rateios { get; init; }
    }
}