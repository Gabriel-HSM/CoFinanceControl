using CoFinanceControl.Application.Categorias.DTOs;
using CoFinanceControl.Application.Categorias.Repositories;
using CoFinanceControl.Application.Exeptions;
using CoFinanceControl.Application.Usuarios.Repositories;
using CoFinanceControl.Domain.Models.Categoria;
using CoFinanceControl.Domain.Models.Categoria.ValueObjects;

namespace CoFinanceControl.Application.Categorias.Services
{
    public sealed class CategoriaService : ICategoriaService
    {
       private readonly ICategoriaRepository  _categoriaRepository;
       private readonly IUsuarioRepository _usuarioRepository;

       public CategoriaService(ICategoriaRepository categoriaRepository, IUsuarioRepository usuarioRepository)
        {
            _categoriaRepository = categoriaRepository;
            _usuarioRepository = usuarioRepository;
        }

        public async Task<CategoriaDto> CriarCategoriaSistemaAsync(CriarCategoriaDto dto, CancellationToken ct = default)
        {
            var (nome, descricao) = CriarValueObjects(dto);
            var existe = await _categoriaRepository.ExisteComNomeAsync(nome, ct);

            if (existe)
            throw new DomainExeption("Não é possível criar a categoria porque já existe uma categoria com o mesmo nome.");

            var categoria = Categoria.CriarCategoriaSis(nome, descricao);

            await _categoriaRepository.AdicionarAsync(categoria, ct);

            return MapearParaDto(categoria);
        }

        public async Task<CategoriaDto> CriarCategoriaUsuarioAsync(Guid usuarioId, CriarCategoriaDto dto, CancellationToken ct = default)
        {
           var (nome, descricao) = CriarValueObjects(dto);
           var existe = await _categoriaRepository.ExisteComNomeAsync(nome, ct);

           var usuarioExiste = await _usuarioRepository.ObterPorIdAsync(usuarioId, ct);

            if (existe)
            throw new DomainExeption("Não é possível criar a categoria porque já existe uma categoria com o mesmo nome.");

            if (usuarioExiste is null)
            throw new UsuarioNaoEncontradoException("Usuario não encontrado ou inexistente");
            
            var categoria = Categoria.CriarCategoriaUser(nome, descricao, usuarioId);

            await _categoriaRepository.AdicionarAsync(categoria, ct);

            return MapearParaDto(categoria);
        }

        public async Task<CategoriaDto?> ObterPorIdAsync (int id, CancellationToken ct = default)
        {
            var categoria = await _categoriaRepository.ObterPorIdAsync(id, ct);

            if(categoria is null)
            throw new CategoriaNaoEncontadoExeption("Categoria não encontrada ou inexistente");

            return MapearParaDto(categoria);
        }

        public async Task<CategoriaDto?> AtualizarAsync (int id, AtualizarCategoriaDto dto, CancellationToken ct = default)
        {
            var categoria = await _categoriaRepository.ObterPorIdAsync(id, ct);

            if (categoria is null)
            throw new CategoriaNaoEncontadoExeption("Categoria não encontrada ou inexistente");

            if (!string.IsNullOrWhiteSpace(dto.Nome) && dto.Nome.Length < 3)
            throw new DomainExeption("O nome deve ter no mínimo 3 caracteres");

            if (!string.IsNullOrWhiteSpace(dto.Descricao) && dto.Descricao.Length < 3)
            throw new DomainExeption("A descrição deve ter no máximo 155 caracteres");

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
            throw new CategoriaNaoEncontadoExeption("Categoria não encontrada ou inexistente");

            return await _categoriaRepository.DeletarAsync(id, ct);
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