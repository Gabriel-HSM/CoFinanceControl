using CoFinanceControl.Domain.Enums;

namespace CoFinanceControl.Application.Common
{
    public interface IJwtService
    {
        string GerarToken(Guid usuarioId, Guid entidadeFinanceiraId, Cargo cargo);
    }
}
