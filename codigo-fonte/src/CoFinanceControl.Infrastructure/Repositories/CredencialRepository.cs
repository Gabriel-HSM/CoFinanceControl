using CoFinanceControl.Application.Credenciais.Repositories;
using CoFinanceControl.Domain.Models.Credencial;
using CoFinanceControl.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CoFinanceControl.Infrastructure.Repositories
{
    public class CredencialRepository : ICredencialRepository
    {
        private readonly CoFinanceDbContext _context;

        public CredencialRepository(CoFinanceDbContext context)
        {
            _context = context;
        }

        public async Task AdicionarAsync(Credencial credencial, CancellationToken ct = default)
        {
            await _context.Credenciais.AddAsync(credencial, ct);
            await _context.SaveChangesAsync(ct);
        }

        public async Task<bool> ExisteComEmailAsync(string email, CancellationToken ct = default)
        {
            return await _context.Credenciais
                .AnyAsync(c => c.Email.Valor == email, ct);
        }

        public async Task<Credencial?> ObterPorEmailAsync(string email, CancellationToken ct = default)
        {
            return await _context.Credenciais
                .FirstOrDefaultAsync(c => c.Email.Valor == email, ct);
        }

        public async Task AtualizarAsync(Credencial credencial, CancellationToken ct = default)
        {
            _context.Credenciais.Update(credencial);
            await _context.SaveChangesAsync(ct);
        }
    }
}
