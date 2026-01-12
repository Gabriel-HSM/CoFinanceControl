namespace CoFinanceControl.Application.Credenciais.DTOs
{
    public sealed record CriarCredencial
    {
        public required Guid UsuarioId { get; init; }
        public required string Email { get; init; }
        public required string Senha { get; init; }
        
    }
}