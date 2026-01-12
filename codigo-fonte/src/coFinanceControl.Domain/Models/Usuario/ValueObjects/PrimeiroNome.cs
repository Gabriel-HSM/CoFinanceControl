namespace CoFinanceControl.Domain.Models.Usuario.ValueObjects
{
    public readonly record struct PrimeiroNome
    {
        public string Valor {get;}

        public PrimeiroNome(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException("O primeiro nome não deve ficar em branco.", nameof(valor));
            }

            if (valor.Length < 3 || valor.Length > 50)
            {
                throw new ArgumentException("O primeiro nome deve ter entre 3 e 50 caracteres.", nameof(valor));
            }

            //Verificação simples para implementação robusta no futuro
            if (valor.Contains(".") || valor.Contains(",") || valor.Contains(";") || valor.Contains(":") || valor.Contains("!") || valor.Contains("?") || valor.Contains("-") || valor.Contains("_"))
            {
                throw new ArgumentException("O primeiro nome não deve conter caracteres especiais.", nameof(valor));
            }

            Valor = valor;
        }
        //Mostrar o valor quando chamar o objeto
        public override string ToString() => Valor;
        //OPeração implicita que irei entender melhor no futuro
        public static implicit operator string(PrimeiroNome primeiroNome) => primeiroNome.Valor;
        
    }
}