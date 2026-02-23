using CoFinanceControl.Application.Conta.Enums;

namespace CoFinanceControl.Application.Conta.DTOs
{
    public sealed record ContaDto
    {
        public Guid UsuarioId { get; init; }
        public Guid EntidadeFinanceiraId { get; init; }
        //Remover em breve 
        public Guid Credencial { get; init; }
        public required string UsuarioNome { get; init; }
        public required string EntidadeNome { get; init; }
        public required string Email { get; init; }
        public required TipoConta TipoConta { get; init; }

    }
}