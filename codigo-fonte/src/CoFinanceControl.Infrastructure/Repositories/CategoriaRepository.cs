using CoFinanceControl.Application.Categorias.Repositories;
using CoFinanceControl.Domain.Models.Categoria;
using CoFinanceControl.Infrastructure.Data;

namespace CoFinanceControl.Infrastructure.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly CoFinanceDbContext _context;

        public CategoriaRepository(CoFinanceDbContext context)
        {
            _context = context;
        }

        public async Task AdicionarAsync (Categoria categoria, CancellationToken ct = default)
        {
            await _context.AddAsync(categoria);
            await _context.SaveChangesAsync(ct);
        }

        // public async Task<Categoria?> ObterPorIdAsync (int id, CancellationToken ct = default)
        // {
        //     return await _context.
        // }
    }
}