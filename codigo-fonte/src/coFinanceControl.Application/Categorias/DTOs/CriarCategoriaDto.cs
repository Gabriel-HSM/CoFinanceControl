using System.ComponentModel.DataAnnotations;

namespace CoFinanceControl.Application.Categorias.DTOs
{
    public sealed record CriarCategoriaDto
    {
        [Required(ErrorMessage = "O nome da categoria não deve ser vazio")]
        [MaxLength(30, ErrorMessage = "O nome deve ter no máximo 30 caracteres")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres")]
        [RegularExpression(@"^[A-Za-zÀ-ÖØ-öø-ÿ0-9 ]+$", ErrorMessage = "Nome não deve conter caracteres especiais")]
        public required string Nome { get; init; }
        [Required(ErrorMessage = "A descrição da categoria não deve ser vazio")]
        [MaxLength(155, ErrorMessage = "A descrição deve ter no máximo 50 caracteres")]
        [MinLength(3, ErrorMessage = "A descrição deve ter no mínimo 3 caracteres")]
        public required string Descricao { get; init; }
        public Guid? UsuarioId { get; init; }
        public string? Icone { get; init; }
    }
}