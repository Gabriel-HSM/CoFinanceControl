using CoFinanceControl.Application.Categorias.Repositories;
using CoFinanceControl.Domain.Models.Categoria;
using CoFinanceControl.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

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

        public async Task<Categoria?> ObterPorIdAsync (int id, CancellationToken ct = default)
        {
            return await _context.Categorias.FirstOrDefaultAsync(c => c.Id == id, ct);
        }

        public async Task AtualizarAsync (Categoria categoria, CancellationToken ct = default)
        {
            _context.Categorias.Update(categoria);
            await _context.SaveChangesAsync(ct);
        }

        public async Task<bool> DeletarAsync (int id, CancellationToken ct = default)
        {
            var categoria = await ObterPorIdAsync(id);

            if (categoria is null)
            return false;

            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync(ct);

            return true;
        }

        public async Task<IEnumerable<Categoria>> ObterTodosAsync (CancellationToken ct = default)
        {
             return await _context.Categorias
                .AsNoTracking()
                .ToListAsync(ct);
        }
    }
}