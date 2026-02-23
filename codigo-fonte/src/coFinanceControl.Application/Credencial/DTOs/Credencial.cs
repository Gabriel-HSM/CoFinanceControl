namespace CoFinanceControl.Application.Credencial.DTOs
{
    public sealed record Credencial
    {
        public int Id { get; init; }
        public Guid UsuarioId { get; init; }
        public required string Email { get; init; }
        public required string Senha { get; init; }
        public required DateTime DataCriacao { get; init; }
        public required DateTime DataAtualizacao { get; init; }
    }
}