using CoFinanceControl.Application.Credenciais.DTOs;

namespace CoFinanceControl.Application.Usuarios.DTOs
{
    public sealed record UsuarioDto
    {
        public required Guid Id {get; init;}
        public required string Nome { get; init; }
        public required string Sobrenome { get; init; }
        public DateOnly? DataNascimento { get; init; }
        public required string TipoPessoa { get; init; }
        public required DateTime DataCriacao { get; init; }
        public DateTime? DataAtualizacao { get; init; }
        //usuario tem uma lista de ids de categorias
        public CredencialDto? Credencial { get; init; }
        
    }
}