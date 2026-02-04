namespace CoFinanceControl.Domain.Models.Transacao.ValueObjects
{
    public readonly record struct TransacaoValor
    {
        public decimal Valor { get; }

        public TransacaoValor(decimal valor)
        {
            if (valor < 0)
            {
                throw new ArgumentOutOfRangeException("O valor não pode ser menor que 0", nameof(valor));
            }

            Valor = valor;
        }

        public override string ToString() => Valor.ToString();
        public static implicit operator decimal(TransacaoValor valor) => valor.Valor;
    }
}