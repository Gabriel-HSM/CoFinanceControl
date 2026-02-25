using CoFinanceControl.Application.EntidadeFinanceiraApp.Repositories;
using CoFinanceControl.Domain.Models.EntidadeFinanceira;
using CoFinanceControl.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CoFinanceControl.Infrastructure.Repositories
{
    public class EntidadeFinanceiraRepository : IEntidadeFinanceiraRepository
    {
        private readonly CoFinanceDbContext _context;

        public EntidadeFinanceiraRepository(CoFinanceDbContext context)
        {
            _context = context;
        }

        public async Task AdicionarAsync(EntidadeFinanceira entidade, CancellationToken ct = default)
        {
            await _context.AddAsync(entidade, ct);
            await _context.SaveChangesAsync(ct);
        }

        public async Task<EntidadeFinanceira?> ObterPorIdAsync(Guid id, CancellationToken ct = default)
        {
            return await _context.EntidadesFinanceiras
                .Include(e => e.Usuarios)
                .FirstOrDefaultAsync(e => e.Id == id, ct);
        }

        public async Task AtualizarAsync(EntidadeFinanceira entidadeFinanceira, CancellationToken ct = default)
        {
            _context.EntidadesFinanceiras.Update(entidadeFinanceira);
            await _context.SaveChangesAsync(ct);
        }

        public async Task<bool> InativarAsync(Guid id, CancellationToken ct = default)
        {
            var entidade = await ObterPorIdAsync(id, ct);

            if (entidade is null)
                return false;

            entidade.Desativar();
            _context.EntidadesFinanceiras.Update(entidade);
            await _context.SaveChangesAsync(ct);

            return true;
        }
    }
}