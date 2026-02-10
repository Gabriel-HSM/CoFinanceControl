using CoFinanceControl.Application.Categorias.Repositories;
using CoFinanceControl.Application.Exeptions;
using CoFinanceControl.Application.Rateios.DTOs;
using CoFinanceControl.Application.Transacoes.DTOs;
using CoFinanceControl.Application.Transacoes.Repositories;
using CoFinanceControl.Application.Usuarios.Repositories;
using CoFinanceControl.Domain.Models.Rateios;
using CoFinanceControl.Domain.Models.Transacao;
using CoFinanceControl.Domain.Models.Transacao.ValueObjects;

namespace CoFinanceControl.Application.Transacoes.Services
{
    public sealed class TransacaoService : ITransacaoService
    {
        private readonly ITransacaoRepository _transacaoRepository;
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IUsuarioRepository _usuarioRepository;

        public TransacaoService(ITransacaoRepository transacaoRepository, ICategoriaRepository categoriaRepository, IUsuarioRepository usuarioRepository)
        {
            _transacaoRepository = transacaoRepository;
            _categoriaRepository = categoriaRepository;
            _usuarioRepository = usuarioRepository;

        }

        public async Task<TransacaoDto> CriarAsync (CriarTransacaoDto dto, CancellationToken ct = default)
        {
            if (dto.Rateios is null || !dto.Rateios.Any())
            throw new DomainExeption("Não é possível cadastrar transação sem categoria e destino");

            var categoriaIds = dto.Rateios
            .Select(r => r.CategoriaId)
            .Distinct()
            .ToList();

            var categoriasExistentes = await _categoriaRepository.ObterVariosIDsValidacao(categoriaIds, ct);

            if (categoriasExistentes.Count != categoriaIds.Count)
            throw new CategoriaNaoEncontadoExeption("Erro de categorias. Uma ou mais estão inválidas, não encontradas ou inexistentes");
            
            var usuarioId = await _usuarioRepository.ObterPorIdAsync(dto.UsuarioId, ct);

            if (usuarioId is null)
            throw new UsuarioNaoEncontradoException("Usuario não encontrado ou inexistente");

            var valorTotal = new TransacaoValor(dto.ValorTotal);
            var descricao = new TransacaoDescricao(dto.Descricao);

            var rateios = dto.Rateios 
                .Select(rateioDto => (rateioDto.CategoriaId, new DestinoRateio(rateioDto.Destino), new ValorRateio(rateioDto.Valor)))
                .ToList();

            //Verificação se a soma dos rateios é igual ao valor total da transação
            decimal somaRateios = 0;

            foreach( var v in rateios){
                somaRateios += v.Item3.Valor;
            }

            if (somaRateios != valorTotal)
            throw new DomainExeption("A soma do valor da categoria está diferente do valor total da transação");

            var transacao = Transacao.Criar(dto.UsuarioId, valorTotal, descricao);
            transacao.DefinirRateios(rateios);

            await _transacaoRepository.AdicionarAsync(transacao, ct);

            return MapearParaDto(transacao);
        }

        public async Task<TransacaoDto?> ObterAsync (int id, CancellationToken ct = default)
        {
            var transacao = await _transacaoRepository.ObterPorIdAsync(id, ct);

            if (transacao is null)
            throw new TransacaoNaoEncontradaExeption("Transação não encontrada ou inexistente");

            return MapearParaDto(transacao);
        }

        public async Task<TransacaoDto?> AtualizarAsync (int id, AtualizarTransacaoDto dto, CancellationToken ct = default)
        {
            if (dto.Rateios is null || !dto.Rateios.Any())
            throw new DomainExeption("Não é possível cadastrar transação sem categoria e destino");

            var transacao = await _transacaoRepository.ObterPorIdAsync(id, ct);

            if (transacao is null)
            throw new TransacaoNaoEncontradaExeption("Transação não encontrada ou inexistente");

            var categoriaIds = dto.Rateios
            .Select(r => r.CategoriaId)
            .Distinct()
            .ToList();

            var categoriasExistentes = await _categoriaRepository.ObterVariosIDsValidacao(categoriaIds, ct);

            if (categoriasExistentes.Count != categoriaIds.Count)
            throw new CategoriaNaoEncontadoExeption("Erro de categorias. Uma ou mais estão inválidas, não encontradas ou inexistentes");

            if (!string.IsNullOrWhiteSpace(dto.Descricao) && dto.Descricao.Length < 3)
            throw new DomainExeption("A descrição deve ter no mínimo 3 caracteres");

            var rateios = dto.Rateios
                .Select(rateioDto => (rateioDto.CategoriaId, new DestinoRateio(rateioDto.Destino), new ValorRateio(rateioDto.Valor)))
                .ToList();

            if (dto.ValorTotal.HasValue && dto.ValorTotal <= 0)
            throw new DomainExeption("O valor não deve ser menor ou igual a 0");

            var valorTotal = dto.ValorTotal.HasValue
                ? new TransacaoValor(dto.ValorTotal.Value)
                : transacao.ValorTotal;

            var descricao = !string.IsNullOrWhiteSpace(dto.Descricao)
                ? new TransacaoDescricao(dto.Descricao)
                : transacao.Descricao;

            //Verificação se a soma dos rateios é igual ao valor total da transação
            decimal somaRateios = 0;

            foreach( var v in rateios){
                somaRateios += v.Item3.Valor;
            }

            if (somaRateios != valorTotal)
            throw new DomainExeption("O valor da categoria está diferente do valor total da transação");

            transacao.Atualizar(valorTotal, descricao);
            transacao.DefinirRateios(rateios);

            await _transacaoRepository.AtualizarAsync(transacao, ct);

            return MapearParaDto(transacao);

        }

        public async Task<bool> DeletarAsync (int id, CancellationToken ct = default)
        {
            var transacao = await _transacaoRepository.ObterPorIdAsync(id, ct);

            if (transacao is null)
            throw new TransacaoNaoEncontradaExeption("Transação não encontrada ou inexistente");

            return await _transacaoRepository.DeletarAsync(id, ct);
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