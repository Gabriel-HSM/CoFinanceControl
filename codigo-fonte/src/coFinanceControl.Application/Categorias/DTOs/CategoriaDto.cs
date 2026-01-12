namespace CoFinanceControl.Application.Categorias.DTOs
{
    public sealed record CategoriaDto
    {
        public required Guid Id { get; init; }
        public required Guid UsuarioId { get; init; }
        public required string Nome { get; init; }
        public required string Descricao { get; init; }
        public required DateTime DataCriacao { get; init; }
        public DateTime? DataAtualizacao { get; init; }
    }
}