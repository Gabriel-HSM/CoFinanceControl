using CoFinanceControl.Domain.Enums;

namespace CoFinanceControl.Application.Autentificacao.DTOs
{
    public sealed record CriarAutentificacaoDto
    {
        public TipoEntidade TipoEntidade { get; init; }
        public required string NomeUsuario { get; init; }
        public required string Sobrenome { get; init; }
        public DateTime? DataNascimento { get; init; }
        public Cargo Cargo { get; init; } = Cargo.Admin;
        public required string Email { get; init; }
        public required string Senha { get; init; }
    }
}