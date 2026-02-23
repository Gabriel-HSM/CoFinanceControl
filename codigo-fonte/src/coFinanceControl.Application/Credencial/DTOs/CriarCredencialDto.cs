namespace CoFinanceControl.Application.Credencial.DTOs
{
    public sealed record CriarCredencialDto
    {
        public required string Email { get; init; }
        public required string Senha { get; init; }
    }
}