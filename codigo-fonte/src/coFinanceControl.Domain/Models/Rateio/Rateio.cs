namespace CoFinanceControl.Domain.Models.Rateio
{
    public sealed class Rateio
    {
        public int Id { get; private set; }
        public int CategoriaId { get; private set; }
        public int TransacaoId { get; private set; }
        public ValorRateio Valor { get; private set; }

        private Rateio(){}

        //Apenas transação pode criar
        internal Rateio(int transacaoId, int categoriaId, ValorRateio valor)
        {
            TransacaoId = transacaoId;
            CategoriaId = categoriaId;
            Valor = valor;
        }
    }
}