using CoFinanceControl.Application.Autentificacao.DTOs;
using CoFinanceControl.Application.Autentificacao.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoFinanceControl.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutentificacaoController : ControllerBase
    {
        private readonly IAutentificacaoService _service;

        public AutentificacaoController(IAutentificacaoService service)
        {
            _service = service;
        }

        [HttpPost("registrar")]
        public async Task<IActionResult> Registrar([FromBody] CriarAutentificacaoDto dto, CancellationToken ct = default)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var resultado = await _service.CriarAsync(dto, ct);
            return Created(string.Empty, resultado);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto dto, CancellationToken ct = default)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // TODO: retornar JWT token quando for implementado
            var resultado = await _service.LoginAsync(dto, ct);
            return Ok(resultado);
        }
    }
}
