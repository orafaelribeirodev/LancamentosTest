using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Entidades;

namespace Projeto.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Lancamento> Lancamentos { get; set; }
    }
}
