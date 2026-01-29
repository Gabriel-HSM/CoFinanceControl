using CoFinanceControl.Application.Usuarios.DTOs;

namespace CoFinanceControl.Application.Usuarios.Services
{
    //Validar regras de negocio
    //O que meu sistema precisa permitir que alguém faça?
    public interface IUsuarioService
    {
        Task<UsuarioDto> CriarAsync (CriarUsuarioDto dto, CancellationToken cancellationToken = default);

        Task<UsuarioDto?> ObterPorIdAsync(Guid id, CancellationToken cancellationToken = default);

        Task<bool> AtualizarAsync (AtualizarUsuarioDto dto, CancellationToken cancellationToken = default);

        Task<bool> DeletarAsync (Guid id, CancellationToken cancellationToken = default);

        
    }
}