using CoFinanceControl.Application.Usuarios.DTOs;

namespace CoFinanceControl.Application.Usuarios.Services
{
    //Validar regras de negocio
    //O que o usuario pode fazer
    public interface IUsuarioService
    {
        Task<UsuarioDto> CriarAsync (CriarUsuarioDto dto, CancellationToken cancellationToken = default);

        Task<UsuarioDto?> ObterPorIdAsync(Guid id, CancellationToken cancellationToken = default);

        Task<bool> AtualizarAsync (AtualizarUsuarioDto dto, CancellationToken cancellationToken = default);

        Task<bool> DeletarAsync (Guid id, CancellationToken cancellationToken = default);

        
    }
}