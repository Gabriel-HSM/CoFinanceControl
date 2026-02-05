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
            var transacao = await _service.CriarAsync(dto, ct);
            return Ok(transacao);
        }
    }
}
