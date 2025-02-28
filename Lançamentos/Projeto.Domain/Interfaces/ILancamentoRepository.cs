using Projeto.Domain.Entidades;

namespace Projeto.Domain.Interfaces
{
    public interface ILancamentoRepository
    {
        Task AdicionarLancamentoAsync(Lancamento lancamento);
        Task<IEnumerable<Lancamento>> ObterLancamentosAsync(DateTime data);
    }
}
