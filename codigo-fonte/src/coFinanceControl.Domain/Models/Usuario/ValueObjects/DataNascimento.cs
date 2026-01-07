namespace CoFinanceControl.Domain.Models.Usuario.ValueObjects
{
    public readonly record struct DataNascimento
    {
        public DateOnly Valor {get;}

        public DataNascimento(DateOnly valor)
        {
            if (valor > DateOnly.FromDateTime(DateTime.UtcNow))
            {
                throw new ArgumentException("A data não pode ser uma data futura", nameof(valor));
            }

            Valor = valor;
        }
        public override string ToString() => Valor.ToString("dd-MM-yyyy");
        public static implicit operator DateOnly(DataNascimento dataNascimento) => dataNascimento.Valor;
    }
}