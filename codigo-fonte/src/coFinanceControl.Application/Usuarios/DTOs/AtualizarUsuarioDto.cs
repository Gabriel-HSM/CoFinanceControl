namespace CoFinanceControl.Application.Usuarios.DTOs
{
    public sealed record AtualizarUsuarioDto
    {
        public required Guid Id { get; init; }
        public required string Nome { get; init; }
        public required string Sobrenome { get; init; }
        public DateOnly? DataNascimento { get; init; }
    }
}