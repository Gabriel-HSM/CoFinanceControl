using CoFinanceControl.Application.Transacoes.DTOs;
using CoFinanceControl.Application.Transacoes.Services;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacaoController : ControllerBase
    {
        private ITransacaoService _service;

        public TransacaoController(ITransacaoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CriarTransacao([FromBody]CriarTransacaoDto dto, CancellationToken ct = default)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var transacao = await _service.CriarAsync(dto, ct);
            return Ok(transacao);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterTransacaoID (
            [FromRoute]int id,
            CancellationToken ct = default)
        {
            var transacao = await _service.ObterAsync(id, ct);

            if (transacao is null)
            return NotFound();

            return Ok(transacao);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarTransacao 
        (
            [FromRoute] int id, 
            [FromBody] AtualizarTransacaoDto dto,
            CancellationToken ct = default)
        {
            var transacao = await _service.AtualizarAsync(id, dto, ct);

            if (transacao is null)
            return NotFound();

            return Ok(transacao);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarTransacao ([FromRoute] int id, CancellationToken ct = default)
        {
            var tranacaoD = await _service.DeletarAsync(id, ct);

            if (!tranacaoD)
            return NotFound();

            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodasTransacoes (CancellationToken ct = default)
        {
            var transacao = await _service.ObterTodosAsync(ct);
            return Ok(transacao);
        }
    }
}
