using CoFinanceControl.Application.Categorias.DTOs;
using CoFinanceControl.Application.Categorias.Repositories;
using CoFinanceControl.Domain.Models.Categoria;
using CoFinanceControl.Domain.Models.Categoria.ValueObjects;

namespace CoFinanceControl.Application.Categorias.Services
{
    public sealed class CategoriaService : ICategoriaService
    {
       private readonly ICategoriaRepository  _categoriaRepository;

       public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<CategoriaDto> CriarCategoriaSistemaAsync(CriarCategoriaDto dto, CancellationToken ct = default)
        {
            var (nome, descricao) = CriarValueObjects(dto);

            var categoria = Categoria.CriarCategoriaSis(nome, descricao);
            await _categoriaRepository.AdicionarAsync(categoria, ct);
            return MapearParaDto(categoria);
        }

        public async Task<CategoriaDto> CriarCategoriaUsuarioAsync(Guid usuarioId, CriarCategoriaDto dto, CancellationToken ct = default)
        {
           var (nome, descricao) = CriarValueObjects(dto);

            var categoria = Categoria.CriarCategoriaUser(nome, descricao, usuarioId);
            await _categoriaRepository.AdicionarAsync(categoria, ct);
            return MapearParaDto(categoria);
        }

        public async Task<CategoriaDto?> ObterPorIdAsync (int id, CancellationToken ct = default)
        {
            var categoria = await _categoriaRepository.ObterPorIdAsync(id, ct);
            return categoria is not null ? MapearParaDto(categoria) : null;
        }

        public async Task<CategoriaDto?> AtualizarAsync (int id, AtualizarCategoriaDto dto, CancellationToken ct = default)
        {
            var categoria = await _categoriaRepository.ObterPorIdAsync(id, ct);

            if (categoria is null){
                return null;
            }

           //Atualização parcial
           var nome = !string.IsNullOrWhiteSpace(dto.Nome)
            ? new CategoriaNome(dto.Nome)
            : categoria.Nome;

            var descricao = !string.IsNullOrWhiteSpace(dto.Descricao)
                ? new CategoriaDescricao(dto.Descricao)
                : categoria.Descricao;

            categoria.Atualizar(nome, descricao);

            await _categoriaRepository.AtualizarAsync(categoria, ct);
            
            return MapearParaDto(categoria);
        }

        public async Task<bool> DeletarAsync(int id, CancellationToken ct = default)
        {
            var categoria = await ObterPorIdAsync(id);

            if (categoria is null)
            {
                return false;
            }

            await _categoriaRepository.DeletarAsync(id, ct);

            return true;
        }

        public async Task<IEnumerable<CategoriaDto>> ObterTodosAsync (CancellationToken ct = default)
        {
           var categoria = await _categoriaRepository.ObterTodosAsync(ct);
           return categoria.Select(MapearParaDto).ToList();
        }

        private static CategoriaDto MapearParaDto(Categoria categoria)
        {
            return new CategoriaDto
            {
                Id = categoria.Id,
                Nome = categoria.Nome,
                Descricao = categoria.Descricao,
                UsuarioId = categoria.UsuarioId,
                Icone = categoria.Icone,
                DataCriacao = categoria.DataCriacao,
                DataAtualizacao = categoria.DataAtualizacao
            };
        }

        private static (CategoriaNome nome, CategoriaDescricao descricao) CriarValueObjects(CriarCategoriaDto dto)
        {
            return(
                new CategoriaNome(dto.Nome),
                new CategoriaDescricao(dto.Descricao)
            );
        }
        
    }
}