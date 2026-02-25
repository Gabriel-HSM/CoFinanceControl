using CoFinanceControl.Application.Autentificacao.DTOs;

namespace CoFinanceControl.Application.Autentificacao.Services
{
    public interface IAutentificacaoService
    {
        Task<ResultadoAutentificacaoDto> CriarAsync(CriarAutentificacaoDto dto, CancellationToken ct = default);

        // TODO: alterar retorno para incluir JWT quando for implementado
        Task<ResultadoAutentificacaoDto> LoginAsync(LoginDto dto, CancellationToken ct = default);
    }
}