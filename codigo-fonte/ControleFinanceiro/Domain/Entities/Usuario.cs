using ControleFinanceiro.Domain.Enums;

namespace ControleFinanceiro.Domain.Entities
{
    //No banco de dados ficaria com S no final, ou seja usuarios
    public class Usuario
    {
        //private porque é id e não quero que outro lugar altere ou crie
        public int Id { get; private set; }
        public required string Nome { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public required DateTime Criado_em { get; set; }
        public required DateTime Atualizado_em { get; set; }
        public Credencial? Credencial { get; set; }
        public ICollection<Categoria>? Categorias { get; set; }
    }
}