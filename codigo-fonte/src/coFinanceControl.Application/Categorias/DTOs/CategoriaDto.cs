namespace CoFinanceControl.Application.Categorias.DTOs
{
    public sealed record CategoriaDto
    {
        public required int Id { get; init; }
        public Guid? UsuarioId { get; init; }
        public required string Nome { get; init; }
        public required string Descricao { get; init; }
        public required string? Icone { get; init; }
        public required DateTime DataCriacao { get; init; }
        public DateTime? DataAtualizacao { get; init; }
    }
}