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

            var categoriaUser = await _service.CriarCategoriaUsuarioAsync(dto.UsuarioId.Value, dto, ct);
            return Ok(categoriaUser);
        }
    }
}
