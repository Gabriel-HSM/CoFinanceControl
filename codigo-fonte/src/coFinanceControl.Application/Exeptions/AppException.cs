namespace CoFinanceControl.Application.Exeptions
{
    public abstract class AppExeption : Exception
    {
        protected AppExeption(string message) : base(message) {}
    }
}