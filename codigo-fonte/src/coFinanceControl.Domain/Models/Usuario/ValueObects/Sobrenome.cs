using System.Text.RegularExpressions;

namespace CoFinanceControl.Domain.Models.Usuario.ValueObects
{
    public readonly record struct Sobrenome
    {
        private static readonly Regex RegexSobrenome = new (@"^[A-Za-zÀ-ÖØ-öø-ÿ ]+$");

        public string Valor { get; }
        
        public Sobrenome(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException("O sobrenome nome não pode ser vazio.", nameof(valor));             
            }

            var sobrenomeNomeSemEspacos = valor.Trim();

            if (sobrenomeNomeSemEspacos.Length > 50)
            {
                throw new ArgumentException("O sobrenome nome não pode ser maior que 50 caracteres.", nameof(valor));
            }

            if (sobrenomeNomeSemEspacos.Length < 3)
            {
                throw new ArgumentException("O sobrenome nome não pode ser menor que 3 caracteres.", nameof(valor));
            }

            if (!RegexSobrenome.IsMatch(valor))
            {
                throw new ArgumentException("Sobrenome contém caracteres inválidos");
            }

            Valor = valor;
        }

        public override string ToString() => Valor;
        //Onde espera sting, pode ser usado o item diretamente
        public static implicit operator string(Sobrenome sobrenome) => sobrenome.Valor;
    }
}