namespace CoFinanceControl.Application.Credencial.DTOs
{
    public sealed record Credencial
    {
        public Guid Id { get; init; }
        public Guid UsuarioId { get; init; }
        public required string Email { get; init; }
        public required DateTime DataCriacao { get; init; }
        public required DateTime DataAtualizacao { get; init; }
    }
}