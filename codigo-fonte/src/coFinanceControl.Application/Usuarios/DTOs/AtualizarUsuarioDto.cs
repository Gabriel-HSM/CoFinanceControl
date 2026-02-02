namespace CoFinanceControl.Application.Usuarios.DTOs
{
    public sealed record AtualizarUsuarioDto
    {
        public string? Nome { get; init; }
        public string? Sobrenome { get; init; }
        public DateOnly? DataNascimento { get; init; }
    }
}