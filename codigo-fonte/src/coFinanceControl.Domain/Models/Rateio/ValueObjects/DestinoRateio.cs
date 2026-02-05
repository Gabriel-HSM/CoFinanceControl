namespace CoFinanceControl.Domain.Models.Rateio.ValueObjects
{
    public readonly record struct DestinoRateio
    {
        public string Valor { get; }

        public DestinoRateio(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            throw new ArgumentNullException("Destino do rateio é obrigatório.", nameof(valor));

            Valor = valor;
        }

        public override string ToString() => Valor;
        public static implicit operator string(DestinoRateio destinoRateio) => destinoRateio.Valor;
    }
}