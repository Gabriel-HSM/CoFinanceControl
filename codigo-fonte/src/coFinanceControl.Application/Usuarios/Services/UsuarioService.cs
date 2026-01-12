using CoFinanceControl.Application.Usuarios.DTOs;
using CoFinanceControl.Application.Usuarios.Repository;
using CoFinanceControl.Domain;
using CoFinanceControl.Domain.Models.Usuario.ValueObjects;

namespace CoFinanceControl.Application.Usuarios.Services
{
    public sealed class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        //Não entendi isso aqui. Porque estou utilizando o Repository dentro do Service?
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<UsuarioDto> CriarUsuarioAsync(CriarUsuarioDto criarUsuarioDto, CancellationToken cancellationToken = default)
        {
            var credencialId = criarUsuarioDto.Credencial.Id;

            if (await _usuarioRepository.ExistePorCredencialIdAsync(credencialId, cancellationToken))
            {
                throw new InvalidOperationException("Usuário já cadastrado.");
            }

            var nome = new PrimeiroNome(criarUsuarioDto.Nome);
            var Sobrenome = new Sobrenome(criarUsuarioDto.Sobrenome);
            DataNascimento? dataNascimento = criarUsuarioDto.DataNascimento.HasValue ? new DataNascimento(criarUsuarioDto.DataNascimento.Value) : null;
            var tipoPessoa = criarUsuarioDto.TipoPessoa;

            var usuario = Usuario.CriarUsuario(nome, Sobrenome, dataNascimento, tipoPessoa);

            await _usuarioRepository.AdicionarAsync(usuario, cancellationToken);

            return MapearParaDto(usuario);
        }

        public async Task<UsuarioDto> ObterUsuarioPorIdAsync(Guid usuarioId, CancellationToken cancellationToken = default)
        {
            var usuario = await _usuarioRepository.ObterPorIdAsync(usuarioId, cancellationToken);
            return usuario is not null ? MapearParaDto(usuario) : null;
        }

        public async Task<UsuarioDto> ObterUsuarioPorCredencialIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var usuario = await _usuarioRepository.ObterPorCredencialIdAsync(id, cancellationToken);
            return usuario is not null ? MapearParaDto(usuario) : null;
        }

        public async Task<bool> RemoverUsuarioAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _usuarioRepository.RemoverAsync(id, cancellationToken);
        }
        public async Task<bool> AtualizarUsuarioAsync(AtualizarUsuarioDto atualizarUsuarioDto, CancellationToken cancellationToken = default)
        {
            var usuario = await _usuarioRepository.ObterPorIdAsync(atualizarUsuarioDto.Id, cancellationToken);

            if (usuario is null)
            {
                return false;
            }

            // Atualização parcial: se o campo não foi fornecido, mantém o valor atual
            var nome = !string.IsNullOrEmpty(atualizarUsuarioDto.Nome)
            ? new PrimeiroNome(atualizarUsuarioDto.Nome)
            : usuario.Nome;

            var sobrenome = !string.IsNullOrEmpty(atualizarUsuarioDto.Sobrenome)
            ? new Sobrenome(atualizarUsuarioDto.Sobrenome)
            : usuario.Sobrenome;

            DataNascimento? dataNascimento = atualizarUsuarioDto.DataNascimento.HasValue
            ? new DataNascimento(atualizarUsuarioDto.DataNascimento.Value)
            : usuario.DataNascimento;

            usuario.AtualizarUsuario(nome, sobrenome, dataNascimento);

            await _usuarioRepository.AtualizarAsync(usuario, cancellationToken);

            return true;
        }

        private static UsuarioDto MapearParaDto(Usuario usuario)
        {
            return new UsuarioDto
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Sobrenome = usuario.Sobrenome,
                DataNascimento = usuario.DataNascimento?.Valor,
                TipoPessoa = usuario.TipoPessoa.ToString(),
                DataCriacao = usuario.DataCriacao,
                DataAtualizacao = usuario.DataAtualizacao,
            };
        }
    }
}