namespace CoFinanceControl.Domain.Models.Transacao.ValueObjects
{
    public readonly record struct ValorTransacao
    {
        public  double Valor {get;}

        public ValorTransacao(double valor)
        {
            //Não pode ser nulo
            if (double.IsNaN(valor))
            {
                throw new ArgumentException("O valor da transação não pode ser nulo.", nameof(valor));
            }
            //Não pode ser menor que 0
            if (double.IsNegative(valor))
            {
                throw new ArgumentException("O valor da transação não pode ser negativo.", nameof(valor));
            }

            Valor = valor;
        }
    }
}