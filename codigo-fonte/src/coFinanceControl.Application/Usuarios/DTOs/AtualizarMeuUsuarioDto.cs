using System.ComponentModel.DataAnnotations;
using CoFinanceControl.Application.Validations;

namespace CoFinanceControl.Application.Usuarios.DTOs
{
    public sealed record AtualizarMeuUsuarioDto
    {
        [MaxLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres")]
        [RegularExpression(@"^[A-Za-zÀ-ÖØ-öø-ÿ ]+$", ErrorMessage = "Nome não deve conter números ou caracteres especiais")]
        public string? Nome { get; init; }
        
        [MaxLength(50, ErrorMessage = "O sobrenome deve ter no máximo 50 caracteres")]
        [RegularExpression(@"^[A-Za-zÀ-ÖØ-öø-ÿ ]+$", ErrorMessage = "Sobrenome não deve conter números ou caracteres especiais")]
        public string? Sobrenome { get; init; }
        
        [DataNascimentoValidate(ErrorMessage = "A data de nascimento não deve ser uma data futura")]
        public DateOnly? DataNascimento { get; init; }
        // Sem Cargo - usuário não pode alterar seu próprio cargo
    }
}
