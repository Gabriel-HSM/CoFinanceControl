using ControleFinanceiro.Domain.Enums;

namespace ControleFinanceiro.Domain.Entities
{
    public class Categoria
    {
        public int Id { get; private set; }
        public required string Nome { get; set; }
        public string? icone { get; set; }
        public TipoTransacao TipoTransacao { get; set; }
        public required DateTime Criado_em { get; set; }
        public required DateTime Atualizado_em { get; set; }
        public int IdUsuario { get; set; }
        public Usuario? Usuario{ get; set; }
        
    }
}