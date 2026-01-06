using CoFinanceControl.Application;
using CoFinanceControl.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoFinanceControl.Infrastructure
{
    public class CredencialRepositoryEf : ICredencialRepository
    {
        private readonly AppDbContext _context;

        public CredencialRepositoryEf(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> RegistrarEmailAsync(Guid idUsuario, string email)
        {
            var credencial = await _context.Credenciais.FirstOrDefaultAsync(c => c.UsuarioId == idUsuario);

            if (email == credencial.Email || email == null)
            {
                return false;
            }

            credencial.Email = email;
            _context.Credenciais.Update(credencial);
            await _context.SaveChangesAsync();

            return true;

        }

        public async Task<bool> AlterarSenhaAsync(Guid idUsuario, string senha, string novaSenha)
        {
            var credencial = await _context.Credenciais.FirstOrDefaultAsync(c => c.UsuarioId == idUsuario);

            if (credencial == null)
            {
                return false;
            } 
            else if (senha != credencial.Senha)
            {
                return false;
            }

            credencial.Senha = novaSenha;
            _context.Credenciais.Update(credencial);
            await _context.SaveChangesAsync();

            return true;
        }



    }
}