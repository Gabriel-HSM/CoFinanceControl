namespace CoFinanceControl.Application.Credenciais.DTOs
{
    public sealed record AtualizarSenha
    {
        public required Guid Id { get; init; }
        public required string SenhaAtual { get; init; }
        public required string NovaSenha { get; init; }
    }
}