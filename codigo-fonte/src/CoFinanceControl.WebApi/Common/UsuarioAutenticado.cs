using CoFinanceControl.Application.Common;
using CoFinanceControl.Domain.Enums;
using System.Security.Claims;

namespace CoFinanceControl.WebApi.Common
{
    // Populado via Claims do JWT
    public class UsuarioAutenticado : IUsuarioAutenticado
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UsuarioAutenticado(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Guid UsuarioId
        {
            get
            {
                var claim = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                return Guid.TryParse(claim, out var id) ? id : Guid.Empty;
            }
        }

        public Guid EntidadeFinanceiraId
        {
            get
            {
                var claim = _httpContextAccessor.HttpContext?.User.FindFirst("EntidadeFinanceiraId")?.Value;
                return Guid.TryParse(claim, out var id) ? id : Guid.Empty;
            }
        }

        public Cargo Cargo
        {
            get
            {
                var claim = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.Role)?.Value;
                return Enum.TryParse<Cargo>(claim, out var cargo) ? cargo : Cargo.OperadorFinanceiro;
            }
        }

        public bool IsAuthenticated =>
            _httpContextAccessor.HttpContext?.User.Identity?.IsAuthenticated ?? false;
    }
}
