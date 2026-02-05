namespace CoFinanceControl.Domain.Models.Rateios
{
    public sealed class Rateio
    {
        public int Id { get; private set; }
        public int CategoriaId { get; private set; }
        public int TransacaoId { get; private set; }
        public DestinoRateio Destino { get; private set; }
        public ValorRateio Valor { get; private set; }

        private Rateio(){}

        //Apenas transação pode criar
        internal Rateio(int transacaoId, DestinoRateio destino, int categoriaId, ValorRateio valor)
        {
            TransacaoId = transacaoId;
            Destino = destino;
            CategoriaId = categoriaId;
            Valor = valor;
        }
    }
}