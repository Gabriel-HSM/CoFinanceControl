namespace CoFinanceControl.Application.Usuarios.DTOs
{
    public sealed record CriarUsuarioDto
    {
        //Não espera id porque id é interno (usuario não passa)
        public required string Nome { get; init; }
        public required string Sobrenome { get; init; }
        public DateOnly? DataNascimento { get; init; }

        //Não espera dataCriação porque é interno (usuario não passa)
        
    }
}