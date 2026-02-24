namespace CoFinanceControl.Application.Common
{
    public interface IUsuarioAutenticado
    {
        Guid UsuarioId { get; }
        Guid EntidadeFinanceiraId { get; }
        bool IsAuthenticated { get; }
    }
}
