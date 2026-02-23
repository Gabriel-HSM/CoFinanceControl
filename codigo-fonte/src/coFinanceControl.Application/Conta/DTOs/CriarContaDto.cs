using System.ComponentModel.DataAnnotations;
using CoFinanceControl.Application.Conta.Enums;
using CoFinanceControl.Application.Validations;

namespace CoFinanceControl.Application.Conta.DTOs
{
    public sealed record CriarContaDto
    {
        //USUARIO
        [Required(ErrorMessage = "O nome do usuário não deve ser vazio")]
        [MaxLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres")]
        [RegularExpression(@"^[A-Za-zÀ-ÖØ-öø-ÿ ]+$", ErrorMessage = "Nome não deve conter números ou caracteres especiais")]
        public required string NomeUsuario { get; init; }

        [Required(ErrorMessage = "O sobrenome do usuário não deve ser vazio")]
        [MaxLength(50, ErrorMessage = "O sobrenome deve ter no máximo 50 caracteres")]
        [MinLength(3, ErrorMessage = "O sobrenome deve ter no mínimo 3 caracteres")]
        [RegularExpression(@"^[A-Za-zÀ-ÖØ-öø-ÿ ]+$", ErrorMessage = "Sobrenome não deve conter números ou caracteres especiais")]
        public required string Sobrenome { get; init; }

        [DataNascimentoValidate(ErrorMessage = "A data de nascimento não deve ser uma data futura")]
        public DateOnly? DataNascimento { get; init; }

        //CREDENCIAL
        [Required(ErrorMessage = "O Email não deve ser vazio")]
        [MaxLength(255, ErrorMessage = "O Email deve ter no máximo 255 caracteres")]
        public required string Email { get; init; }

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$", ErrorMessage = "A senha deve ter no mínimo 8 caracteres, incluindo maiúscula, minúscula, número e caractere especial.")]
        public required string Senha { get; init; }

        //ENTIDADE FINANCEIRA
        [Required(ErrorMessage = "O nome não deve ser vazio")]
        [MaxLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres")]
        [RegularExpression(@"^[A-Za-zÀ-ÖØ-öø-ÿ ]+$", ErrorMessage = "Nome não deve conter números ou caracteres especiais")]
        public required string NomeEntidade { get; init; }
        
        public required TipoConta TipoConta { get; init; }
    }
}