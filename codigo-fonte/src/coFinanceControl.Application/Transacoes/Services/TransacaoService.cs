using CoFinanceControl.Application.Rateios.DTOs;
using CoFinanceControl.Application.Transacoes.DTOs;
using CoFinanceControl.Application.Transacoes.Repositories;
using CoFinanceControl.Domain.Models.Transacao;
using CoFinanceControl.Domain.Models.Transacao.ValueObjects;

namespace CoFinanceControl.Application.Transacoes.Services
{
    public sealed class TransacaoService : ITransacaoService
    {
        private ITransacaoRepository _transacaoRepository;

        public TransacaoService(ITransacaoRepository transacaoRepository)
        {
            _transacaoRepository = transacaoRepository;
        }

        public async Task<TransacaoDto> CriarAsync (CriarTransacaoDto dto, CancellationToken ct = default)
        {
           var valorTotal = new TransacaoValor(dto.ValorTotal);
           var descricao = new TransacaoDescricao(dto.Descricao);

           var transacao = Transacao.Criar(dto.UsuarioId, valorTotal, descricao);

           await _transacaoRepository.AdicionarAsync(transacao, ct);

           return MapearParaDto(transacao);
        }

        public async Task<TransacaoDto?> ObterAsync (int id, CancellationToken ct = default)
        {
            var transacao = await _transacaoRepository.ObterPorIdAsync(id, ct);
            if (transacao is null)
            {
                return null;
            }

            return MapearParaDto(transacao);
        }

        public async Task<TransacaoDto?> AtualizarAsync (int id, AtualizarTransacaoDto dto, CancellationToken ct = default)
        {
            var transacao = await _transacaoRepository.ObterPorIdAsync(id, ct);

            if (transacao is null)
            return null;

            var valorTotal = dto.ValorTotal.HasValue
                ? new TransacaoValor(dto.ValorTotal.Value)
                : transacao.ValorTotal;

            var descricao = !string.IsNullOrWhiteSpace(dto.Descricao)
                ? new TransacaoDescricao(dto.Descricao)
                : transacao.Descricao;

            transacao.Atualizar(valorTotal, descricao);

            await _transacaoRepository.AtualizarAsync(transacao, ct);

            return MapearParaDto(transacao);

        }

        public async Task<bool> DeletarAsync (int id, CancellationToken ct = default)
        {
            var transacao = await _transacaoRepository.ObterPorIdAsync(id, ct);

            if (transacao is null)
            return false;

            await _transacaoRepository.DeletarAsync(id, ct);
            return true;
        }

        public async Task<IEnumerable<TransacaoDto>> ObterTodosAsync (CancellationToken ct = default)
        {
            var transacoes = await _transacaoRepository.ObterTodosAsync(ct);
            return transacoes.Select(MapearParaDto).ToList();
        }

        public static TransacaoDto MapearParaDto(Transacao transacao)
        {
            return new TransacaoDto
            {
                Id = transacao.Id,
                UsuarioId = transacao.UsuarioId,
                ValorTotal = transacao.ValorTotal,
                Descricao = transacao.Descricao,
                DataCriacao = transacao.DataCriacao,
                DataAtualizacao = transacao.DataAtualizacao,

                //Cria rateio DTO na transacão
                Rateios = transacao.Rateios.Select(rateio => new RateioDto
                {
                    CategoriaId = rateio.CategoriaId,
                    Valor = rateio.Valor
                }).ToList()
            };
        } 

    }
}