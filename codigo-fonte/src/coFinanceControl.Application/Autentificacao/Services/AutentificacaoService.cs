using BCrypt.Net;
using CoFinanceControl.Application.Autentificacao.DTOs;
using CoFinanceControl.Application.Common;
using CoFinanceControl.Application.Credenciais.Repositories;
using CoFinanceControl.Application.EntidadeFinanceiraApp.Repositories;
using CoFinanceControl.Application.Exeptions;
using CoFinanceControl.Application.Usuarios.Repositories;
using CoFinanceControl.Domain.Enums;
using CoFinanceControl.Domain.Models.Credencial;
using CoFinanceControl.Domain.Models.Credencial.ValueObjects;
using CoFinanceControl.Domain.Models.EntidadeFinanceira;
using CoFinanceControl.Domain.Models.EntidadeFinanceira.ValueObjects;
using CoFinanceControl.Domain.Models.Usuario;
using CoFinanceControl.Domain.Models.Usuario.ValueObects;

namespace CoFinanceControl.Application.Autentificacao.Services
{
    public sealed class AutentificacaoService : IAutentificacaoService
    {
        private readonly IEntidadeFinanceiraRepository _entidadeFinanceiraRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ICredencialRepository _credencialRepository;
        private readonly IJwtService _jwtService;

        public AutentificacaoService(
            IEntidadeFinanceiraRepository entidadeFinanceiraRepository,
            IUsuarioRepository usuarioRepository,
            ICredencialRepository credencialRepository,
            IJwtService jwtService)
        {
            _entidadeFinanceiraRepository = entidadeFinanceiraRepository;
            _usuarioRepository = usuarioRepository;
            _credencialRepository = credencialRepository;
            _jwtService = jwtService;
        }

        public async Task<ResultadoAutentificacaoDto> CriarAsync(CriarAutentificacaoDto dto, CancellationToken ct = default)
        {
            var emailExiste = await _credencialRepository.ExisteComEmailAsync(dto.Email, ct);
            if (emailExiste)
                throw new DomainExeption("Este email ja esta em uso.");

            var nomeEntidade = new EntidadeNome($"{dto.NomeUsuario} {dto.Sobrenome}");
            var entidade = EntidadeFinanceira.Criar(nomeEntidade, dto.TipoEntidade);
            await _entidadeFinanceiraRepository.AdicionarAsync(entidade, ct);

            var nome = new PrimeiroNome(dto.NomeUsuario);
            var sobrenome = new Sobrenome(dto.Sobrenome);
            DataNascimento? dataNascimento = dto.DataNascimento.HasValue
                ? new DataNascimento(DateOnly.FromDateTime(dto.DataNascimento.Value))
                : null;

            var usuario = Usuario.Criar(nome, sobrenome, dataNascimento, entidade.Id, Cargo.Admin);
            await _usuarioRepository.AdicionarAsync(usuario, ct);

            _ = new Senha(dto.Senha);

            var senhaHash = BCrypt.Net.BCrypt.HashPassword(dto.Senha);
            var email = new Email(dto.Email);
            var credencial = Credencial.CriarComEmailSenha(usuario.Id, email, Senha.DeHash(senhaHash));
            await _credencialRepository.AdicionarAsync(credencial, ct);

            var token = _jwtService.GerarToken(usuario.Id, entidade.Id, usuario.Cargo);

            return new ResultadoAutentificacaoDto
            {
                UsuarioId = usuario.Id,
                EntidadeFinanceiraId = entidade.Id,
                Token = token
            };
        }

        public async Task<ResultadoAutentificacaoDto> LoginAsync(LoginDto dto, CancellationToken ct = default)
        {
            var credencial = await _credencialRepository.ObterPorEmailAsync(dto.Email, ct);

            if (credencial is null)
                throw new DomainExeption("Email ou senha invalidos.");

            var senhaValida = BCrypt.Net.BCrypt.Verify(dto.Senha, credencial.SenhaHash?.Valor);
            if (!senhaValida)
                throw new DomainExeption("Email ou senha invalidos.");

            var usuario = await _usuarioRepository.ObterPorIdAsync(credencial.UsuarioId, ct);

            if (usuario is null)
                throw new UsuarioNaoEncontradoException("Usuario nao encontrado.");

            var token = _jwtService.GerarToken(usuario.Id, usuario.EntidadeFinanceiraId, usuario.Cargo);

            return new ResultadoAutentificacaoDto
            {
                UsuarioId = usuario.Id,
                EntidadeFinanceiraId = usuario.EntidadeFinanceiraId,
                Token = token
            };
        }
    }
}
