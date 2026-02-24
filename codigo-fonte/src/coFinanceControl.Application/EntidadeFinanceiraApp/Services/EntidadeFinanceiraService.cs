using CoFinanceControl.Application.Common;
using CoFinanceControl.Application.EntidadeFinanceiraApp.DTOs;
using CoFinanceControl.Application.EntidadeFinanceiraApp.Repositories;
using CoFinanceControl.Application.Exeptions;
using CoFinanceControl.Domain.Models.EntidadeFinanceira;
using CoFinanceControl.Domain.Models.EntidadeFinanceira.ValueObjects;

namespace CoFinanceControl.Application.EntidadeFinanceiraApp.Services
{
    public sealed class EntidadeFinanceiraService : IEntidadeFinanceiraService
    {
        private readonly IEntidadeFinanceiraRepository _entidadeFinanceiraRepository;
        private readonly IUsuarioAutenticado _usuarioAutenticado;

        public EntidadeFinanceiraService(IEntidadeFinanceiraRepository entidadeFinanceiraRepository, IUsuarioAutenticado usuarioAutenticado)
        {
            _entidadeFinanceiraRepository = entidadeFinanceiraRepository;
            _usuarioAutenticado = usuarioAutenticado;

        }

        public async Task<EntidadeFinanceiraDto> ObterAsync(CancellationToken ct = default)
        {
            var entidadeId = _usuarioAutenticado.EntidadeFinanceiraId;
            var entidade = await _entidadeFinanceiraRepository.ObterPorIdAsync(entidadeId, ct);

            if (entidade is null)
            throw new EntidadeFinanceiraNaoEncontradaException("Entidade financeira não encontrada.");

            return MapearParaDto(entidade);
        }

        public async Task<EntidadeFinanceiraDto?> AtualizarAsync(Guid id, AtualizarEntidadeDto dto, CancellationToken ct = default)
        {
            var entidade = await _entidadeFinanceiraRepository.ObterPorIdAsync(id, ct);

            if (entidade is null)
            throw new EntidadeFinanceiraNaoEncontradaException("Entidade financeira não encontrada.");

            var nome = !string.IsNullOrWhiteSpace(dto.Nome) 
                ? new EntidadeNome(dto.Nome)
                : entidade.Nome;

            entidade.Atualizar(nome);

            await _entidadeFinanceiraRepository.AtualizarAsync(entidade, ct);

            return MapearParaDto(entidade);
        }

        public async Task<bool> InativarAsync(Guid id, CancellationToken ct = default)
        {
            var entidade = await _entidadeFinanceiraRepository.ObterPorIdAsync(id, ct);

            if (entidade is null)
            throw new EntidadeFinanceiraNaoEncontradaException("Entidade financeira não encontrada.");

            if (!entidade.Ativo)
            throw new EntidadeFinanceiraInativaException("Conta já inativa/excluda");

            entidade.Desativar();
            return true;
        }

        private static EntidadeFinanceiraDto MapearParaDto(EntidadeFinanceira entidadeFinanceira)
        {
            return new EntidadeFinanceiraDto
            {
                Id = entidadeFinanceira.Id,
                Nome = entidadeFinanceira.Nome,
                TipoEntidade = entidadeFinanceira.TipoEntidade,
                DataCriacao = entidadeFinanceira.DataCriacao,
                Ativo = entidadeFinanceira.Ativo,
                DataDesativacao = entidadeFinanceira.DataDesativacao
            };
        }
    }
}