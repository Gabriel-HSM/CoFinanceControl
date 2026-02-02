
using CoFinanceControl.Domain.Models.Categoria;

namespace CoFinanceControl.Application.Categorias.Repositories
{
    public interface ICategoriaRepository
    {
        Task AdicionarAsync (Categoria categoria, CancellationToken ct = default);
        Task<Categoria?> ObterPorIdAsync (int id, CancellationToken ct = default);
        Task AtualizarAsync (Categoria categoria, CancellationToken ct = default); 
        Task<bool> DeletarAsync (int id, CancellationToken ct = default);
        Task<IEnumerable<Categoria>> ObterTodosAsync (CancellationToken ct = default); 
    }
}