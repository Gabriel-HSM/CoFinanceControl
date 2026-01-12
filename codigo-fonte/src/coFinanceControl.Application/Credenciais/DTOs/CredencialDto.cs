namespace CoFinanceControl.Application.Credenciais.DTOs
{
    public sealed record CredencialDto
    {
        public required Guid Id { get; init; }
        public required Guid UsuarioId { get; init; }
        public required string Email { get; init; }
        public required string Senha { get; init; }
    }
}