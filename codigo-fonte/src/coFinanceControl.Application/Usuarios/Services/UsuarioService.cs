using CoFinanceControl.Application.Usuarios.DTOs;
using CoFinanceControl.Application.Usuarios.Repositories;
using CoFinanceControl.Domain.Models.Usuario.ValueObects;

namespace CoFinanceControl.Application.Usuarios.Services
{
    public sealed class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<UsuarioDto> CriarAsync(CriarUsuarioDto dto, CancellationToken cancellationToken = default)
        {
            //Aqui seria validação de credencial unica.

            //Converte dados do DTO para VOs
            var nome = new PrimeiroNome(dto.Nome);
            var sobrenome = new Sobrenome(dto.Sobrenome);
            DataNascimento? dataNascimento = dto.DataNascimento.
                ? new DataNascimento(dto.DataNascimento)
                : null;


        }
        
    }
}