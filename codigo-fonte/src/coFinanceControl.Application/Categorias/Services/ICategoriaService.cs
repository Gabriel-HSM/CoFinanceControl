using CoFinanceControl.Application.Categorias.DTOs;

namespace CoFinanceControl.Application.Categorias.Services
{
    public interface ICategoriaService
    {
        Task<CategoriaDto> CriarCategoriaSistemaAsync (CriarCategoriaDto dto, CancellationToken ct = default);
        Task<CategoriaDto> CriarCategoriaUsuarioAsync (Guid usuarioId, CriarCategoriaDto dto, CancellationToken ct = default);
        Task<CategoriaDto?> ObterPorIdAsync (int id, CancellationToken ct = default);
        Task<CategoriaDto?> AtualizarAsync (int id, AtualizarCategoriaDto dto, CancellationToken ct = default);
        Task<bool> DeletarAsync (int id, CancellationToken ct = default); 
        Task<IEnumerable<CategoriaDto>> ObterTodosAsync (CancellationToken ct = default);
    }
}