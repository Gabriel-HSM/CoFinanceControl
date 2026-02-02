using CoFinanceControl.Application.Usuarios.DTOs;
using CoFinanceControl.Application.Usuarios.Repositories;
using CoFinanceControl.Domain.Models.Usuario;
using System.Linq;
using CoFinanceControl.Domain.Models.Usuario.ValueObects;

//O que meu sistema precisa permitir que alguém faça?

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
            DataNascimento? dataNascimento = dto.DataNascimento.HasValue
                ? new DataNascimento(dto.DataNascimento.Value)
                : null;


            //Cria o usuario
            var usuario = Usuario.Criar(nome, sobrenome, dataNascimento);

            //"Adiciona no banco"
            await _usuarioRepository.AdicionarAsync(usuario, cancellationToken);

            //retorna DTO mapeado
            return MapearParaDto(usuario);
        }

        public async Task<UsuarioDto?> ObterPorIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var usuario = await _usuarioRepository.ObterPorIdAsync(id, cancellationToken);
            return usuario is not null ? MapearParaDto(usuario) : null;
        }

        public async Task<bool> AtualizarAsync(Guid id, AtualizarUsuarioDto dto, CancellationToken cancellationToken = default)
        {
            var usuario = await _usuarioRepository.ObterPorIdAsync(id, cancellationToken);

            if(usuario is null)
            return false;

            //atualização parcial se o campo não foi fornecido, mantem valor atual
            var nome = !string.IsNullOrWhiteSpace(dto.Nome)
                ? new PrimeiroNome(dto.Nome)
                : usuario.Nome;

            var sobrenome = !string.IsNullOrWhiteSpace(dto.Sobrenome)
                ? new Sobrenome(dto.Sobrenome)
                : usuario.Sobrenome;

            DataNascimento? dataNascimento = dto.DataNascimento.HasValue
                ? new DataNascimento(dto.DataNascimento.Value)
                : usuario.DataNascimento;

            usuario.Atualizar(nome, sobrenome, dataNascimento);

            await _usuarioRepository.AtualizarAsync(usuario, cancellationToken);

            return true;
        }

        public async Task<bool> DeletarAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _usuarioRepository.DeletarAsync(id, cancellationToken);
        }

        public async Task<IEnumerable<UsuarioDto>> ObterTodosAsync (CancellationToken cancellationToken = default)
        {
            var usuarios = await _usuarioRepository.ObterTodosAsync(cancellationToken);
            return usuarios.Select(MapearParaDto).ToList();
        }

        private static UsuarioDto MapearParaDto(Usuario usuario)
        {
            return new UsuarioDto
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Sobrenome = usuario.Sobrenome,
                DataNascimento = usuario.DataNascimento?.Valor,
                DataCriacao = usuario.DataCriacao,
                DataAtualizacao = usuario.DataAtualizacao
            };
        }
        
    }
}