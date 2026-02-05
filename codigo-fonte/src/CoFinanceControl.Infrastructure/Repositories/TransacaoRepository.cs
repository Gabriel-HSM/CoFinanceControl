using CoFinanceControl.Application.Transacoes.Repositories;
using CoFinanceControl.Domain.Models.Transacao;
using CoFinanceControl.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CoFinanceControl.Infrastructure.Repositories
{
    public class TransacaoRepository : ITransacaoRepository
    {
        private CoFinanceDbContext _context;

        public TransacaoRepository(CoFinanceDbContext context)
        {
            _context = context;
        } 

        public async Task AdicionarAsync(Transacao transacao, CancellationToken ct = default)
        {
            await _context.Transacoes.AddAsync(transacao, ct);
            await _context.SaveChangesAsync(ct);
        }

        public async Task<Transacao?> ObterPorIdAsync (int id, CancellationToken ct = default)
        {
            return await _context.Transacoes.FirstOrDefaultAsync(t => t.Id == id, ct);
        } 

        public async Task AtualizarAsync (Transacao transacao, CancellationToken ct = default)
        {
            _context.Transacoes.Update(transacao);
            await _context.SaveChangesAsync(ct);
        }

        public async Task<bool> DeletarAsync (int id, CancellationToken ct = default)
        {
            var transacao = await ObterPorIdAsync(id, ct);

            if (transacao is null)
            return false;

            _context.Transacoes.Remove(transacao);
            await _context.SaveChangesAsync(ct);
            return true;
        }

        public async Task<IEnumerable<Transacao>> ObterTodosAsync (CancellationToken ct = default)
        {
            return await _context.Transacoes
            .AsNoTracking().ToListAsync(ct);
        }
    }
}