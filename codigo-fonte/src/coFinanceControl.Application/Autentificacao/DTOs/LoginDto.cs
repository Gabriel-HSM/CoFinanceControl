namespace CoFinanceControl.Application.Autentificacao.DTOs
{
    public sealed record LoginDto
    {
        public required string Email { get; set; }
        public required string Senha { get; set; }
    }
}