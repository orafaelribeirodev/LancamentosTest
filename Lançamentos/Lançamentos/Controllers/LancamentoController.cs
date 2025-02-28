using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Services;
using Projeto.Domain.Entidades;

namespace Projeto.Api.Controllers
{
    [ApiController]
    [Route("api/lancamentos")]
    public class LancamentoController : ControllerBase
    {
        private readonly LancamentoService _lancamentoService;

        public LancamentoController(LancamentoService lancamentoService)
        {
            _lancamentoService = lancamentoService;
        }

        [HttpPost]
        public async Task<IActionResult> CriarLancamento([FromBody] Lancamento lancamento)
        {
            await _lancamentoService.AdicionarLancamentoAsync(lancamento.Valor, lancamento.Tipo);
            return Ok(new { Message = "Lançamento criado com sucesso!" });
        }

        [HttpGet("{data}")]
        public async Task<ActionResult<IEnumerable<Lancamento>>> ObterLancamentos(DateTime data)
        {
            var lancamentos = await _lancamentoService.ObterLancamentosAsync(data);
            return Ok(lancamentos);
        }
    }
}
