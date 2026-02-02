namespace CoFinanceControl.Application.Categorias.DTOs
{
    public sealed record CriarCategoriaDto
    {
        public required string Nome { get; init; }
        public required string Descricao { get; init; }
        public Guid? UsuarioId { get; init; }
        public string? Icone { get; init; }
    }
}