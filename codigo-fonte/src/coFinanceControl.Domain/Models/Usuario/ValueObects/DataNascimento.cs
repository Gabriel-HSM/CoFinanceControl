namespace CoFinanceControl.Domain.Models.Usuario.ValueObects
{
    public readonly record struct DataNascimento
    {
        //Ajusta o tipo de dado esperado, nesse caso é DateOnly pois é necessário apenas a Data
        public DateOnly Valor { get; }

        public DataNascimento(DateOnly valor)
        {
            DateOnly hoje = DateOnly.FromDateTime(DateTime.UtcNow);
            //Não pode ter nascido no futuro
            if (valor > hoje)
            {
                throw new InvalidDataException("A data de nascimento não deve ser uma data futura");
            }

            Valor = valor;
        }

        public override string ToString() => Valor.ToString("dd/MM/yyyy");

        public static implicit operator DateOnly(DataNascimento dataNascimento) => dataNascimento.Valor;
    
    }
}