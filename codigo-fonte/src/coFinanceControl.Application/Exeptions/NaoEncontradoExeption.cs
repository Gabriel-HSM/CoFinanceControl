namespace CoFinanceControl.Application.Exeptions
{
    public class NaoEncontradoExeption : AppExeption
    {
        public NaoEncontradoExeption(string message) : base(message){}
    }
}