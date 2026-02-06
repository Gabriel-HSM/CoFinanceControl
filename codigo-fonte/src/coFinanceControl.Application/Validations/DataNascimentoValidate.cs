using System.ComponentModel.DataAnnotations;

namespace CoFinanceControl.Application.Validations
{
    public class DataNascimentoValidate : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is null)
                return ValidationResult.Success;

            var hoje = DateOnly.FromDateTime(DateTime.Today);

            if (value is DateOnly dataOnly)
            {
                if (dataOnly > hoje)
                    return new ValidationResult(ErrorMessage ?? "A data de nascimento não deve ser uma data futura");
                return ValidationResult.Success;
            }

            if (value is DateTime data)
            {
                if (DateOnly.FromDateTime(data) > hoje)
                    return new ValidationResult(ErrorMessage ?? "A data de nascimento não deve ser uma data futura");
                return ValidationResult.Success;
            }

            return new ValidationResult("Tipo inválido para DataNascimento.");
        }
        
    }
}