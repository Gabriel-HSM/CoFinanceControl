using Microsoft.AspNetCore.Mvc;

namespace CoFinanceControl.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CriarUsuarioDto dto, CancellationToken ct = default)
        {
            var usuario = await _service.CriarAsync(dto, ct);
            // retorna 201 com Location para GET by id
            return CreatedAtAction(nameof(GetById), new { id = usuario.Id }, usuario);
        }
        
    }
}
