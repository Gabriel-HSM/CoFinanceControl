using CoFinanceControl.Application.EntidadeFinanceiraApp.DTOs;
using CoFinanceControl.Application.EntidadeFinanceiraApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoFinanceControl.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EntidadeFinanceiraController : ControllerBase
    {
        private readonly IEntidadeFinanceiraService _service;

        public EntidadeFinanceiraController(IEntidadeFinanceiraService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Obter(CancellationToken ct = default)
        {
            var entidade = await _service.ObterAsync(ct);
            return Ok(entidade);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Atualizar(
            [FromRoute] Guid id,
            [FromBody] AtualizarEntidadeDto dto,
            CancellationToken ct = default)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var atualizado = await _service.AtualizarAsync(id, dto, ct);
            return Ok(atualizado);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Inativar(
            [FromRoute] Guid id,
            CancellationToken ct = default)
        {
            await _service.InativarAsync(id, ct);
            return NoContent();
        }

        [HttpPatch("{id}/tipo")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AlterarTipo(
            [FromRoute] Guid id,
            [FromBody] AlterarTipoEntidadeDto dto,
            CancellationToken ct = default)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var atualizado = await _service.AlterarTipoEntidadeAsync(id, dto, ct);
            return Ok(atualizado);
        }
    }
}
