namespace CoFinanceControl.Application.Credenciais.DTOs
{
    public sealed record AtualizarEmail
    {
        public required Guid Id { get; init; }
        public required string NovoEmail { get; init; }
        public required string SenhaAtual { get; init; }
    }
}