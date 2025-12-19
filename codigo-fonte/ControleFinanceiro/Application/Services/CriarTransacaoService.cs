
using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Infrastructure;

namespace ControleFinanceiro.Application.Services
{
    public class CriarTransacaoService
    {
        private readonly AppDbContext _context;

        public CriarTransacaoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> ExecutarAsync(
            Transacao transacao)
        {
            _context.Transacoes.Add(transacao);
            await  _context.SaveChangesAsync();
            return transacao.Id;
        }
        
    }
}