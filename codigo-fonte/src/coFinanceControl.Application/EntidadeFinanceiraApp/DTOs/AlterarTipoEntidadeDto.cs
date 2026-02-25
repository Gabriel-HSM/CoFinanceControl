using CoFinanceControl.Domain.Enums;

namespace CoFinanceControl.Application.EntidadeFinanceiraApp.DTOs
{
    public sealed record AlterarTipoEntidadeDto
    {
        public TipoEntidade NovoTipo { get; init; }
    }
}
