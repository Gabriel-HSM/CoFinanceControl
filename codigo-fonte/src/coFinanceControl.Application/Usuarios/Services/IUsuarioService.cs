using CoFinanceControl.Application.Usuarios.DTOs;

namespace CoFinanceControl.Application.Usuarios.Services
{
    //Validar regras de negocio
    //O que meu sistema precisa permitir que alguém faça?
    public interface IUsuarioService
    {
        Task<UsuarioDto> CriarAsync (CriarUsuarioDto dto, CancellationToken cancellationToken = default);

        Task<UsuarioDto?> ObterPorIdAsync(Guid id, CancellationToken cancellationToken = default);

        // Usuário atualiza a si mesmo (sem cargo)
        Task<UsuarioDto?> AtualizarMeuPerfilAsync (AtualizarMeuUsuarioDto dto, CancellationToken cancellationToken = default);

        // Admin atualiza outro usuário (pode alterar cargo)
        Task<UsuarioDto?> AtualizarOutroUsuarioAsync (Guid id, AtualizarOutroUsuarioDto dto, CancellationToken cancellationToken = default);

        Task<bool> DeletarAsync (Guid id, CancellationToken cancellationToken = default);

        Task<IEnumerable<UsuarioDto>> ObterTodosAsync (CancellationToken cancellationToken = default);
        
    }
}