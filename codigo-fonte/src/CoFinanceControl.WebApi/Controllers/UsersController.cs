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
        public async Task<IActionResult> ObterUsuarioId([FromRoute] Guid id, CancellationToken cancellationToken = default)
        {
            var usuario = await _service.ObterPorIdAsync(id, cancellationToken);
            
            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarUsuario(
            [FromRoute] Guid id,
            [FromBody] AtualizarUsuarioDto dto,
            [FromServices]IUsuarioService usuarioService,
            CancellationToken cancellationToken = default)
        {
            var usuarioAtualizado = await usuarioService.AtualizarAsync(id, dto, cancellationToken);

            return Ok(usuarioAtualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarUsuario([FromRoute] Guid id, CancellationToken cancellationToken = default)
        {
            var usuario = await _service.DeletarAsync(id, cancellationToken);
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
