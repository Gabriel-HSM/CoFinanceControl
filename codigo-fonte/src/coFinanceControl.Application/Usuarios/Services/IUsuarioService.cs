using CoFinanceControl.Application.Usuarios.DTOs;

namespace CoFinanceControl.Application.Usuarios.Services
{
    public interface IUsuarioService
    {
        Task<UsuarioDto> CriarUsuarioAsync(CriarUsuarioDto criarUsuarioDto, CancellationToken cancellationToken = default);
        Task<UsuarioDto?> ObterUsuarioPorIdAsync(Guid usuarioId, CancellationToken cancellationToken = default);
        Task<UsuarioDto?> ObterUsuarioPorCredencialIdAsync(Guid credencialId, CancellationToken cancellationToken = default);
        Task<bool> RemoverUsuarioAsync(Guid usuarioId, CancellationToken cancellationToken = default);
        //Acho que se eu quisesse eu poderia retornar o UsuarioDto
        Task<bool> AtualizarUsuarioAsync(AtualizarUsuarioDto atualizarUsuarioDto, CancellationToken cancellationToken = default);
    }
}