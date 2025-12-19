using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ControleFinanceiro.Application.Services;
using ControleFinanceiro.Domain.Entities;

namespace ControleFinanceiro.Controllers
{
    [ApiController]
    [Route("api/transacoes")]
    public class TransacoesController : ControllerBase
    {
        private readonly CriarTransacaoService _service;

        public TransacoesController(CriarTransacaoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] CriarTransacaoRequest request)
        {
            var transacao = new Transacao(
                request.UsuarioId,
                request.CategoriaId,
                request.ContaId,
                request.Valor,
                request.Data,
                request.Tipo,
                request.Descricao);

            var id = await _service.ExecutarAsync(transacao);
            return CreatedAtAction(nameof(Criar), new { id});
        }
    }

    public record CriarTransacaoRequest
    (
        Guid UsuarioId,
        Guid CategoriaId,
        Guid ContaId,
        decimal Valor,
        DateTime Data,
        string Tipo,
        string Descricao
    );
}
