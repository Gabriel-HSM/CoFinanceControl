using CoFinanceControl.Application.EntidadeFinanceiraApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntidadeFinanceiraController : ControllerBase
    {
        private readonly IEntidadeFinanceiraService _service;

        public EntidadeFinanceiraController(IEntidadeFinanceiraService service)
        {
            _service = service;
        }

        
    }
}
