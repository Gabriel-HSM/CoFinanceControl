using CoFinanceControl.Domain.Enums;

namespace CoFinanceControl.Application.Common
{
    public interface IUsuarioAutenticado
    {
        Guid UsuarioId { get; }
        Guid EntidadeFinanceiraId { get; }
        Cargo Cargo { get; }
        bool IsAuthenticated { get; }
    }
}
