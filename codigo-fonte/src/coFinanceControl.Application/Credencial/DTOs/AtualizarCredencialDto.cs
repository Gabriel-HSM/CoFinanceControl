using System.ComponentModel.DataAnnotations;

namespace CoFinanceControl.Application.Credencial.DTOs
{
    public sealed record AtualizarCredencialDto
    {
        [Required(ErrorMessage = "O Email não deve ser vazio")]
        [MaxLength(255, ErrorMessage = "O Email deve ter no máximo 255 caracteres")]
        public required string Email { get; init; }
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$", ErrorMessage = "A senha deve ter no mínimo 8 caracteres, incluindo maiúscula, minúscula, número e caractere especial.")]
        public required string Senha { get; init; }
    }
}