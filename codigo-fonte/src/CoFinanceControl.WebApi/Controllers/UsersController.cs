using CoFinanceControl.Application.Usuarios.DTOs;
using CoFinanceControl.Application.Usuarios.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoFinanceControl.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsuarioService _service;

        public UsersController(IUsuarioService service)
        {
            _service = service;
        }   

        [HttpPost]
        public async Task<IActionResult> CriarUsuario([FromBody] CriarUsuarioDto dto, CancellationToken cancellationToken = default)
        {
            var usuario = await _service.CriarAsync (dto, cancellationToken);
            return Created("", usuario);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterUsuarioId(
            [FromRoute] Guid id, 
            CancellationToken cancellationToken = default)
        {
            var usuario = await _service.ObterPorIdAsync(id, cancellationToken);

            if (usuario is null)
            {
                return NotFound();
            }
            
            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarUsuario(
            [FromRoute] Guid id,
            [FromBody] AtualizarUsuarioDto dto,
            CancellationToken cancellationToken = default)
        {
            var usuarioAtualizado = await _service.AtualizarAsync(id, dto, cancellationToken);

            if (_service.ObterPorIdAsync(id) == null)
            {
                return NotFound();
            }

            return Ok(usuarioAtualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarUsuario(
            [FromRoute] Guid id,
            CancellationToken cancellationToken = default)
        {
            await _service.DeletarAsync(id, cancellationToken);
            if (_service.ObterPorIdAsync(id) == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodosUsuariosAsync (CancellationToken cancellationToken = default)
        {
            var usuario = await _service.ObterTodosAsync(cancellationToken);
            return Ok(usuario);
        }
    }
}
