namespace CoFinanceControl.Domain
{
    public class Categoria
    {
        public Guid Id { get; set; }
        public required string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public required Usuario Usuario { get; set; }
    }
}