using System.Text.RegularExpressions;

namespace CoFinanceControl.Domain.Models.Usuario.ValueObects
{
    //Readonly: será validado, então sobreescrever é um erro.
    //Record: itens do mesmo valor serão iguais.
    //Struct: otimização de memória.
    public readonly record struct PrimeiroNome
    {
        private static readonly Regex RegexNome = new (@"^[A-Za-zÀ-ÖØ-öø-ÿ ]+$");
        public string Valor {get;}

        public PrimeiroNome(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException("O primeiro nome não pode ser vazio.", nameof(valor));
            }

            var primeiroNomeSemEspacos = valor.Trim();

            if (primeiroNomeSemEspacos.Length > 50)
            {
                throw new ArgumentException("O primeiro nome não pode ter mais de 50 caracteres.", nameof(valor));
            }

            if (primeiroNomeSemEspacos.Length < 3)
            {
                throw new ArgumentException("O Primeiro nome não deve ser menor que 3 caracteres", nameof(valor));
            }

            if (!RegexNome.IsMatch(valor))
            throw new ArgumentException("Nome contém caracteres inválidos");

            Valor = valor.Trim();
        }

        //Ao chamar o Valor do sobrenome, retorna seu valor em si, e não o objeto
        public override string ToString() => Valor;

        //Onde espera sting, pode ser usado o item diretamente
        public static implicit operator string(PrimeiroNome primeiroNome) => primeiroNome.Valor;
        
    }
}