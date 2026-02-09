using System.Text.Encodings.Web;
using CoFinanceControl.Application.Categorias.Repositories;
using CoFinanceControl.Application.Rateios.DTOs;
using CoFinanceControl.Application.Transacoes.DTOs;
using CoFinanceControl.Application.Transacoes.Repositories;
using CoFinanceControl.Domain.Models.Rateios;
using CoFinanceControl.Domain.Models.Transacao;
using CoFinanceControl.Domain.Models.Transacao.ValueObjects;

namespace CoFinanceControl.Application.Transacoes.Services
{
    public sealed class TransacaoService : ITransacaoService
    {
        private ITransacaoRepository _transacaoRepository;
        private ICategoriaRepository _categoriaRepository;

        public TransacaoService(ITransacaoRepository transacaoRepository, ICategoriaRepository categoriaRepository)
        {
            _transacaoRepository = transacaoRepository;
            _categoriaRepository = categoriaRepository;

        }

        public async Task<TransacaoDto> CriarAsync (CriarTransacaoDto dto, CancellationToken ct = default)
        {
            if (dto.Rateios is null || !dto.Rateios.Any())
            throw new ArgumentException("Não é possível cadastrar transação sem categoria e destino");

            var categoriaIds = dto.Rateios
            .Select(r => r.CategoriaId)
            .Distinct()
            .ToList();

            var categoriasExistentes = await _categoriaRepository.ObterVariosIDsValidacao(categoriaIds, ct);

            if (categoriasExistentes.Count != categoriaIds.Count)
            throw new ArgumentException("Erro de categorias. Uma ou mais estão inválidas, não encontradas ou inexistentes"); 

            var valorTotal = new TransacaoValor(dto.ValorTotal);
            var descricao = new TransacaoDescricao(dto.Descricao);

            var rateios = dto.Rateios? 
                .Select(rateioDto => (rateioDto.CategoriaId, new DestinoRateio(rateioDto.Destino), new ValorRateio(rateioDto.Valor)))
                .ToList();

            //Verificação se a soma dos rateios é igual ao valor total da transação
            decimal somaRateios = 0;

            if (rateios is null)
            throw new ArgumentException("Não é possível cadastrar transação sem categoria e destino");

            foreach( var v in rateios){
                somaRateios += v.Item3.Valor;
            }

            var transacao = Transacao.Criar(dto.UsuarioId, valorTotal, descricao);

            if (somaRateios != valorTotal)
            throw new ArgumentException("O valor da categoria está diferente do valor total da transção");

            transacao.DefinirRateios(rateios);

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
            var rateios = dto.Rateios
                .Select(rateioDto => (rateioDto.CategoriaId, new DestinoRateio(rateioDto.Destino), new ValorRateio(rateioDto.Valor)))
                .ToList();

            if (transacao is null)
            return null;

            var valorTotal = dto.ValorTotal.HasValue
                ? new TransacaoValor(dto.ValorTotal.Value)
                : transacao.ValorTotal;

            var descricao = !string.IsNullOrWhiteSpace(dto.Descricao)
                ? new TransacaoDescricao(dto.Descricao)
                : transacao.Descricao;

            transacao.Atualizar(valorTotal, descricao);
            transacao.DefinirRateios(rateios);

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
                    Destino = rateio.Destino,
                    Valor = rateio.Valor
                }).ToList()
            };
        } 

    }
}