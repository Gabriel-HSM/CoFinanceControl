using CoFinanceControl.Application.Autentificacao.DTOs;

namespace CoFinanceControl.Application.Autentificacao.Services
{
    public interface IAutentificacaoService
    {
        Task<ResultadoAutentificacaoDto> CriarAsync(CriarAutentificacaoDto dto, CancellationToken ct = default);

        Task<LoginDto> LoginAsync(LoginDto dto, CancellationToken ct = default);
    }
}