using System.ComponentModel.DataAnnotations;

namespace CoFinanceControl.Application.EntidadeFinanceiraApp.DTOs
{
    public sealed record AtualizarEntidadeDto
    {
        [Required(ErrorMessage = "O nome do usuário não deve ser vazio")]
        [MaxLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres")]
        [RegularExpression(@"^[A-Za-zÀ-ÖØ-öø-ÿ ]+$", ErrorMessage = "Nome não deve conter números ou caracteres especiais")]
        public required string Nome { get; init; }
    }
}