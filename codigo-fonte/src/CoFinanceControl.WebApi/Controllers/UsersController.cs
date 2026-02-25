using CoFinanceControl.Application.Usuarios.DTOs;
using CoFinanceControl.Application.Usuarios.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

//controller limpo porque as verificacoes estao no service
namespace CoFinanceControl.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUsuarioService _service;

        public UsersController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CriarUsuario([FromBody] CriarUsuarioDto dto, CancellationToken cancellationToken = default)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var usuario = await _service.CriarAsync(dto, cancellationToken);
            return CreatedAtAction(nameof(ObterUsuarioId), new { id = usuario.Id }, usuario);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterUsuarioId(
            [FromRoute] Guid id,
            CancellationToken cancellationToken = default)
        {
            var usuario = await _service.ObterPorIdAsync(id, cancellationToken);
            return Ok(usuario);
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarMeuUsuario(
            [FromBody] AtualizarMeuUsuarioDto dto,
            CancellationToken cancellationToken = default)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var atualizado = await _service.AtualizarMeuPerfilAsync(dto, cancellationToken);

            if (atualizado is null)
                return NotFound();

            return Ok(atualizado);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AtualizarOutroUsuario(
            [FromRoute] Guid id,
            [FromBody] AtualizarOutroUsuarioDto dto,
            CancellationToken cancellationToken = default)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var atualizado = await _service.AtualizarOutroUsuarioAsync(id, dto, cancellationToken);

            if (atualizado is null)
                return NotFound();

            return Ok(atualizado);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeletarUsuario(
            [FromRoute] Guid id,
            CancellationToken cancellationToken = default)
        {
            var deletado = await _service.DeletarAsync(id, cancellationToken);
            if (!deletado)
                return NotFound();

            return NoContent();
        }

        [HttpGet]
        [Authorize(Roles = "Admin,GerenteFinanceiro")]
        public async Task<IActionResult> ObterTodosUsuariosAsync(CancellationToken cancellationToken = default)
        {
            var usuarios = await _service.ObterTodosAsync(cancellationToken);
            return Ok(usuarios);
        }
    }
}
