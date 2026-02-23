using System.Text.RegularExpressions;

namespace CoFinanceControl.Domain.Models.EntidadeFinanceira.ValueObjects
{
    public readonly record struct EntidadeNome
    {
        private static readonly Regex RegexNome = new(@"^[A-Za-zÀ-ÖØ-öø-ÿ ]+$");
        public string Valor { get; }

        public EntidadeNome(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException("O nome não pode ser vazio.", nameof(valor));
            }

            var primeiroNomeSemEspacos = valor.Trim();

            if (primeiroNomeSemEspacos.Length > 50)
            {
                throw new ArgumentException("O nome não pode ter mais de 50 caracteres.", nameof(valor));
            }

            if (primeiroNomeSemEspacos.Length < 3)
            {
                throw new ArgumentException("O nome não deve ser menor que 3 caracteres", nameof(valor));
            }

            if (!RegexNome.IsMatch(valor))
            throw new ArgumentException("Nome contém caracteres inválidos");

            Valor = valor.Trim();
        }
        public override string ToString() => Valor;
        public static implicit operator string(EntidadeNome nome) => nome.Valor;
    }
}