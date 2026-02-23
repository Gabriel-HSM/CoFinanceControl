namespace CoFinanceControl.Application.Credencial.DTOs
{
    public sealed record AtualizarCredencialDto
    {
        public required string Email { get; init; }
        public required string Senha { get; init; }
    }
}