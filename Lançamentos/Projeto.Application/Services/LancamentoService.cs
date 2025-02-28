using Projeto.Domain.Entidades;
using Projeto.Domain.Interfaces;

namespace Projeto.Application.Services
{
    public class LancamentoService
    {
        private readonly ILancamentoRepository _lancamentoRepository;

        public LancamentoService(ILancamentoRepository lancamentoRepository)
        {
            _lancamentoRepository = lancamentoRepository;
        }

        public async Task AdicionarLancamentoAsync(decimal valor, string tipo)
        {
            var lancamento = new Lancamento(valor, tipo);
            await _lancamentoRepository.AdicionarLancamentoAsync(lancamento);
        }

        public async Task<IEnumerable<Lancamento>> ObterLancamentosAsync(DateTime data)
        {
            return await _lancamentoRepository.ObterLancamentosAsync(data);
        }
    }
}
