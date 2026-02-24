using CoFinanceControl.Domain.Enums;

namespace CoFinanceControl.Application.EntidadeFinanceiraApp.DTOs
{
    public sealed record EntidadeFinanceiraDto
    {
        public Guid Id { get; init; }
        public required string Nome { get; init; }
        public TipoEntidade TipoEntidade { get; init; }
        public DateTime DataCriacao { get; init; }
        public bool Ativo { get; init; }
        public DateTime? DataDesativacao { get; init; }

    }
}