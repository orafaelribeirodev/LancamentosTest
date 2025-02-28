namespace Projeto.Domain.Entidades
{
    public class Lancamento
    {
        public Guid Id { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime Data { get; private set; }
        public string Tipo { get; private set; } // Crédito ou Débito

        public Lancamento(decimal valor, string tipo)
        {
            Id = Guid.NewGuid();
            Valor = valor;
            Data = DateTime.UtcNow;
            Tipo = tipo;
        }
    }
}
