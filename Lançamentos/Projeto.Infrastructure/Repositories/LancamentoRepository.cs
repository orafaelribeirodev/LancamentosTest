using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Entidades;
using Projeto.Domain.Interfaces;
using Projeto.Infrastructure.Data;

namespace Projeto.Infrastructure.Repositories
{
    public class LancamentoRepository : ILancamentoRepository
    {
        private readonly ApplicationDbContext _context;

        public LancamentoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AdicionarLancamentoAsync(Lancamento lancamento)
        {
            await _context.Lancamentos.AddAsync(lancamento);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Lancamento>> ObterLancamentosAsync(DateTime data)
        {
            return await _context.Lancamentos
                .Where(l => l.Data.Date == data.Date)
                .ToListAsync();
        }
    }
}
