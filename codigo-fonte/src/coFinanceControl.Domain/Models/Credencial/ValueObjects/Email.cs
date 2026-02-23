using System.Text.RegularExpressions;

namespace CoFinanceControl.Domain.Models.Credencial.ValueObjects
{
    public readonly record struct Email
    {
        private static readonly Regex RegexEmail = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);
        public string Valor { get; }


        public Email(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException("O email não pode estar vazio", nameof(valor));
            }

            var valorTrim = valor.Trim();

            if (valorTrim.Length > 255)
            {
                throw new ArgumentException("O email não pode exceder 255 caracteres", nameof(valor));
            }

            if (!RegexEmail.IsMatch(valorTrim))
            {
                throw new ArgumentException("Email inválido", nameof(valor));
            }

            Valor = valorTrim;
        }
        public override string ToString() => Valor;
        public static implicit operator string(Email email) => email.Valor;
    }
}