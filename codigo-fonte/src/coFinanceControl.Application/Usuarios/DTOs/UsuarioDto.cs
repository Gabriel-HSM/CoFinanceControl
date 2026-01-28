namespace CoFinanceControl.Application.Usuarios.DTOs
{
    //Resposta do sistema para o usuario
    
    //Faz sentido usar record pq se o usuario tiver o mesmo id/ser igual, ele são o mesmo item
    //Caixas de transporte não precisam de herança
    //init define as propriedade apenas na criação do objeto (ou seja atibuir itens a ele depois de ciado, não funciona)

    public sealed record UsuarioDto
    {
        public required Guid Id { get; init; }
        public required string Nome { get; init; }
        public required string Sobrenome { get; init; }
        public DateOnly? DataNascimento { get; init; }
        public required DateTime DataCriacao { get; init; }
        public required DateTime DataAtualizacao { get; init; }
    }
}