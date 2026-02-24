using System.ComponentModel.DataAnnotations;
using CoFinanceControl.Application.Validations;
using CoFinanceControl.Domain.Enums;

namespace CoFinanceControl.Application.Usuarios.DTOs
{
    public sealed record AtualizarOutroUsuarioDto
    {
        [MaxLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres")]
        [RegularExpression(@"^[A-Za-zÀ-ÖØ-öø-ÿ ]+$", ErrorMessage = "Nome não deve conter números ou caracteres especiais")]
        public string? Nome { get; init; }
        
        [MaxLength(50, ErrorMessage = "O sobrenome deve ter no máximo 50 caracteres")]
        [RegularExpression(@"^[A-Za-zÀ-ÖØ-öø-ÿ ]+$", ErrorMessage = "Sobrenome não deve conter números ou caracteres especiais")]
        public string? Sobrenome { get; init; }
        
        [DataNascimentoValidate(ErrorMessage = "A data de nascimento não deve ser uma data futura")]
        public DateOnly? DataNascimento { get; init; }
        
        // Admin pode alterar o cargo de outro usuário
        public Cargo? Cargo { get; init; }
    }
}
