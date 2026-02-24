namespace CoFinanceControl.Application.Exeptions
{
    public class EntidadeFinanceiraNaoEncontradaException : AppExeption
    {
        public EntidadeFinanceiraNaoEncontradaException(string message) : base(message){}
    }
}