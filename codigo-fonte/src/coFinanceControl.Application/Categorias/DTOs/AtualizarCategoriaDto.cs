using System.ComponentModel.DataAnnotations;

namespace CoFinanceControl.Application.Categorias.DTOs
{
    public sealed record AtualizarCategoriaDto
    {
        [MaxLength(30, ErrorMessage = "O nome deve ter no máximo 30 caracteres")]
        [RegularExpression(@"^[A-Za-zÀ-ÖØ-öø-ÿ0-9 ]+$", ErrorMessage = "Nome não deve conter caracteres especiais")]
        public string? Nome { get; init; }
        [MaxLength(155, ErrorMessage = "A descrição deve ter no máximo 50 caracteres")]
        public string? Descricao { get; init; }
        public string? Icone { get; init; }
    }
}