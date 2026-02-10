namespace CoFinanceControl.Application.Exeptions
{
    public class UsuarioNaoEncontradoException : AppExeption
    {
        public UsuarioNaoEncontradoException(string message) : base(message){}
    }
}