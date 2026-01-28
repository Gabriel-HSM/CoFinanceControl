using CoFinanceControl.Domain.Models.Usuario;

namespace CoFinanceControl.Application.Usuarios.Repositories
{
    //Será utilizado no infrastructure
    //Responsável pelo que é possivel fazer com o USUARIO
    public interface IUsuarioRepository
    {
        //operações longas caso demora ele cancela
        Task AdicionarAsync(Usuario usuario, CancellationToken cancellationToken = default);

        Task<Usuario?> ObterPorIdAsync(Guid id ,CancellationToken cancellationToken = default);

        Task<Usuario> AtualizarAsync(Usuario usuario, CancellationToken cancellationToken = default);

        Task<bool> DeletarAsync (Guid id, CancellationToken cancellationToken = default);
    }
}