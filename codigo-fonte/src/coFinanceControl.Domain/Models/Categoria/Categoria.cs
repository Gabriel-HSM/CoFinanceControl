using CoFinanceControl.Domain.Models.Categoria.ValueObjects;
//isSistema existe para que categorias preexistentes perteçam ao sistema, e as proximas aos usuarios.

namespace CoFinanceControl.Domain.Models.Categoria
{
    public sealed class Categoria
    {
        public int Id { get; private set; }
        public Guid? UsuarioId { get; private set;}
        public CategoriaNome Nome { get; private set; }
        public CategoriaDescricao Descricao { get; private set; }
        public string? Icone { get; private set; }
        public bool isSistema { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataAtualizacao { get; private set; }

        private Categoria(){}

        public static Categoria CriarCategoriaSis(CategoriaNome nome, CategoriaDescricao descricao)
        {
            return new Categoria
            {
                Nome = nome,
                Descricao = descricao,
                isSistema = true,
                UsuarioId = null,
                DataCriacao = DateTime.UtcNow
            };
        }

        public static Categoria CriarCategoriaUser(CategoriaNome nome, CategoriaDescricao descricao, Guid usuarioId)
        {
            return new Categoria
            {
                Nome = nome,
                Descricao = descricao,
                isSistema = false,
                UsuarioId = usuarioId,
                DataCriacao = DateTime.UtcNow
            };
        }
        
        public void Atualizar(CategoriaNome nome, CategoriaDescricao descricao)
        {
            Nome = nome;
            Descricao = descricao;
            DataAtualizacao = DateTime.UtcNow;
        }
    }
}