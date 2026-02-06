using CoFinanceControl.Application.Categorias.DTOs;
using CoFinanceControl.Application.Categorias.Services;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaService _service;

        public CategoriasController(ICategoriaService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CriarCategoria(
            [FromBody] CriarCategoriaDto dto,
            CancellationToken ct = default)
        {
            if(dto.UsuarioId is null)
            {
                var categoriaSis = await _service.CriarCategoriaSistemaAsync(dto, ct);
                return Ok(categoriaSis);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var categoriaUser = await _service.CriarCategoriaUsuarioAsync(dto.UsuarioId.Value, dto, ct);
            return Ok(categoriaUser);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult>  ObterCategoriaId ([FromRoute] int id, CancellationToken ct = default)
        {
            var categoria = await _service.ObterPorIdAsync(id, ct);

            if (categoria is null)
            return NotFound();

            return Ok(categoria);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarCategoria (
            [FromRoute] int id,
            [FromBody] AtualizarCategoriaDto dto,
            CancellationToken ct = default)
        {
            var cateAtualizado = await _service.AtualizarAsync(id, dto, ct);

            if (cateAtualizado is null)
            return NotFound();

            return Ok(cateAtualizado);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarCategoria (
            [FromRoute] int id,
            CancellationToken ct = default
        )
        {
            var deletado = await _service.DeletarAsync(id, ct);

            if (!deletado)
            {
                return NotFound();
            }
            
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodasCategorias (CancellationToken ct = default)
        {
            var categorias = await _service.ObterTodosAsync(ct);

            return Ok(categorias);
        }
    }
}
