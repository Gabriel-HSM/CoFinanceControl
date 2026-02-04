namespace CoFinanceControl.Domain.Models.Rateio
{
    public readonly record struct ValorRateio
    {
        public decimal Valor { get; }

        public ValorRateio(decimal valor)
        {
            if (valor < 0)
            {
                throw new ArgumentOutOfRangeException("O valor não pode ser menor que 0", nameof(valor));
            }

            Valor = valor;
        }

        public override string ToString() => Valor.ToString();
        public static implicit operator decimal(ValorRateio valor) => valor.Valor;
    }
}