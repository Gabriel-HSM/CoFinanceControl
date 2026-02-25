using CoFinanceControl.Application.Common;
using CoFinanceControl.Application.EntidadeFinanceiraApp.Repositories;
using CoFinanceControl.Application.Exeptions;
using CoFinanceControl.Application.Usuarios.DTOs;
using CoFinanceControl.Application.Usuarios.Repositories;
using CoFinanceControl.Domain.Enums;
using CoFinanceControl.Domain.Models.Usuario;
using CoFinanceControl.Domain.Models.Usuario.ValueObects;

//O que meu sistema precisa permitir que alguém faça?

namespace CoFinanceControl.Application.Usuarios.Services
{
    public sealed class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IUsuarioAutenticado _usuarioAutenticado;
        private readonly IEntidadeFinanceiraRepository _entidadeFinanceiraRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository, IUsuarioAutenticado usuarioAutenticado, IEntidadeFinanceiraRepository entidadeFinanceiraRepository)
        {
            _usuarioRepository = usuarioRepository;
            _usuarioAutenticado = usuarioAutenticado;
            _entidadeFinanceiraRepository = entidadeFinanceiraRepository;
        }

        public async Task<UsuarioDto> CriarAsync(CriarUsuarioDto dto, CancellationToken cancellationToken = default)
        {
            //Converte dados do DTO para VOs
            var nome = new PrimeiroNome(dto.Nome);
            var sobrenome = new Sobrenome(dto.Sobrenome);
            DataNascimento? dataNascimento = dto.DataNascimento.HasValue
                ? new DataNascimento(dto.DataNascimento.Value)
                : null;
                
            var cargo = dto.Cargo;
            
            //Pega o EntidadeFinanceiraId do usuario autenticado
            var entidadeId = _usuarioAutenticado.EntidadeFinanceiraId;

            //Busca a entidade financeira (já carrega a coleção de Usuarios para validação)
            var entidade = await _entidadeFinanceiraRepository.ObterPorIdAsync(entidadeId, cancellationToken);

            if (entidade is null)
                throw new EntidadeFinanceiraNaoEncontradaException("Entidade não encontrada ou inexistente");

            //Cria o usuario
            var usuario = Usuario.Criar(nome, sobrenome, dataNascimento, entidadeId, cargo);

            //Valida regra de negócio (ex: Solo só permite 1 usuário) e adiciona à coleção
            entidade.AdicionarUsuario(usuario);

            //Persiste o usuario no banco
            await _usuarioRepository.AdicionarAsync(usuario, cancellationToken);

            //retorna DTO mapeado
            return MapearParaDto(usuario);
        }

        public async Task<UsuarioDto?> ObterPorIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var usuario = await _usuarioRepository.ObterPorIdAsync(id, cancellationToken);

            if(usuario is null)
            throw new UsuarioNaoEncontradoException("Usuario não encontrado ou inexistente");


            return MapearParaDto(usuario);
        }

        public async Task<UsuarioDto?> AtualizarMeuPerfilAsync(AtualizarMeuUsuarioDto dto, CancellationToken cancellationToken = default)
        {
            // Obtém o usuário autenticado (a si mesmo)
            var usuarioId = _usuarioAutenticado.UsuarioId;
            var usuario = await _usuarioRepository.ObterPorIdAsync(usuarioId, cancellationToken);

            if(usuario is null)
            throw new UsuarioNaoEncontradoException("Usuario não encontrado ou inexistente");

            if (!string.IsNullOrWhiteSpace(dto.Nome) && dto.Nome.Length < 3)
            throw new DomainExeption("O nome deve ter no mínimo 3 caracteres");

            if (!string.IsNullOrWhiteSpace(dto.Sobrenome) && dto.Sobrenome.Length < 3)
            throw new DomainExeption("O sobrenome deve ter no mínimo 3 caracteres");

            // Atualização parcial - mantém valores atuais se não fornecidos
            var nome = !string.IsNullOrWhiteSpace(dto.Nome)
                ? new PrimeiroNome(dto.Nome)
                : usuario.Nome;

            var sobrenome = !string.IsNullOrWhiteSpace(dto.Sobrenome)
                ? new Sobrenome(dto.Sobrenome)
                : usuario.Sobrenome;

            DataNascimento? dataNascimento = dto.DataNascimento.HasValue
                ? new DataNascimento(dto.DataNascimento.Value)
                : usuario.DataNascimento;

            // Cargo não muda - mantém o atual
            usuario.Atualizar(nome, sobrenome, dataNascimento, usuario.Cargo);

            await _usuarioRepository.AtualizarAsync(usuario, cancellationToken);

            return MapearParaDto(usuario);
        }

        public async Task<UsuarioDto?> AtualizarOutroUsuarioAsync(Guid id, AtualizarOutroUsuarioDto dto, CancellationToken cancellationToken = default)
        {
            var usuario = await _usuarioRepository.ObterPorIdAsync(id, cancellationToken);

            if(usuario is null)
            throw new UsuarioNaoEncontradoException("Usuario não encontrado ou inexistente");

            if (!string.IsNullOrWhiteSpace(dto.Nome) && dto.Nome.Length < 3)
            throw new DomainExeption("O nome deve ter no mínimo 3 caracteres");

            if (!string.IsNullOrWhiteSpace(dto.Sobrenome) && dto.Sobrenome.Length < 3)
            throw new DomainExeption("O sobrenome deve ter no mínimo 3 caracteres");

            // Atualização parcial
            var nome = !string.IsNullOrWhiteSpace(dto.Nome)
                ? new PrimeiroNome(dto.Nome)
                : usuario.Nome;

            var sobrenome = !string.IsNullOrWhiteSpace(dto.Sobrenome)
                ? new Sobrenome(dto.Sobrenome)
                : usuario.Sobrenome;

            DataNascimento? dataNascimento = dto.DataNascimento.HasValue
                ? new DataNascimento(dto.DataNascimento.Value)
                : usuario.DataNascimento;

            // Cargo: só muda se for fornecido e diferente
            Cargo cargo = dto.Cargo.HasValue ? dto.Cargo.Value : usuario.Cargo;

            usuario.Atualizar(nome, sobrenome, dataNascimento, cargo);

            await _usuarioRepository.AtualizarAsync(usuario, cancellationToken);

            return MapearParaDto(usuario);
        }

        public async Task<bool> DeletarAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var usuario = await _usuarioRepository.ObterPorIdAsync(id, cancellationToken);

            if (usuario is null)
            throw new UsuarioNaoEncontradoException("Usuario não encontrado ou inexistente");

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