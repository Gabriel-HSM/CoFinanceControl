using CoFinanceControl.Application.Credenciais.DTOs;
using CoFinanceControl.Domain.Enums;

namespace CoFinanceControl.Application.Usuarios.DTOs
{
    public class CriarUsuarioDto
    {
        public required string Nome { get; init; }
        public required string Sobrenome { get; init; }
        public DateOnly? DataNascimento { get; init; }
        public required TipoPessoa TipoPessoa { get; init; }
        //usuario pode ou não ter credencial
        public CredencialDto? Credencial { get; init; }
        
    }
}