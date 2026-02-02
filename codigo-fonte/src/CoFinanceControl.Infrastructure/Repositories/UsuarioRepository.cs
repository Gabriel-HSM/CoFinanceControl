using CoFinanceControl.Application.Usuarios.Repositories;
using CoFinanceControl.Domain.Models.Usuario;
using CoFinanceControl.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CoFinanceControl.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        //De fato as implementações no Banco de dados
        private readonly CoFinanceDbContext _context;

        public UsuarioRepository(CoFinanceDbContext context)
        {
            _context = context;
        }

        public async Task AdicionarAsync(Usuario usuario, CancellationToken cancellationToken = default)
        {
            await _context.Usuarios.AddAsync(usuario, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<Usuario?> ObterPorIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
        }

        public async Task AtualizarAsync(Usuario usuario, CancellationToken cancellationToken = default)
        {
            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<bool> DeletarAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var usuario = await ObterPorIdAsync(id, cancellationToken);

            if(usuario is null)
            return false;

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<IEnumerable<Usuario>> ObterTodosAsync (CancellationToken cancellationToken)
        {
            return await _context.Usuarios
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }
    }
}