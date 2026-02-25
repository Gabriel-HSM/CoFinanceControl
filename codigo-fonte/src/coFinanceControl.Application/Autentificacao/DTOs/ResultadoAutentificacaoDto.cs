namespace CoFinanceControl.Application.Autentificacao.DTOs
{
    public sealed class ResultadoAutentificacaoDto
    {
        public Guid UsuarioId { get; init; }
        public Guid EntidadeFinanceiraId { get; init; }
        public string Token { get; init; } = string.Empty;
    }
}