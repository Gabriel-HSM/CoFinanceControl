namespace CoFinanceControl.Domain.Models.Transacao.ValueObjects
{
    public readonly record struct Valor
    {
        public decimal Value { get; }

        public Valor(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("O valor não pode ser menor que 0", nameof(value));
            }

            Value = value;
        }

        public override string ToString() => Value.ToString();
        public static implicit operator decimal(Valor valor) => valor.Value;
    }
}