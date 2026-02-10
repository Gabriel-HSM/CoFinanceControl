namespace CoFinanceControl.Application.Exeptions
{
    public class TransacaoNaoEncontradaExeption : AppExeption
    {
        public TransacaoNaoEncontradaExeption(string message) : base(message){}
    }
}