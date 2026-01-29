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
        public async Task<IActionResult> Create([FromBody] CriarUsuarioDto dto, CancellationToken cancellationToken = default)
        {
            var usuario = await _service.CriarAsync (dto, cancellationToken);
            return Created("", usuario);
        }
        
    }
}
