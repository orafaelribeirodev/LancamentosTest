using Projeto.Application.Services;
using Projeto.Domain.Interfaces;
using Moq;
using System.Threading.Tasks;
using Xunit;
using Projeto.Domain.Entidades;

public class LancamentoServiceTests
{
    [Fact]
    public async Task AdicionarLancamento_DeveSalvarLancamento()
    {
        var repoMock = new Mock<ILancamentoRepository>();
        var service = new LancamentoService(repoMock.Object);

        await service.AdicionarLancamentoAsync(100, "Crédito");

        repoMock.Verify(r => r.AdicionarLancamentoAsync(It.IsAny<Lancamento>()), Times.Once);
    }
}
