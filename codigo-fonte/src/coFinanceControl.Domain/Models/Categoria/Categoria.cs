using CoFinanceControl.Domain.Enums;
using CoFinanceControl.Domain.Models.Categoria.ValueObjects;

namespace CoFinanceControl.Domain
{
    public class Categoria
    {
        public Guid Id { get; private set; }
        public Guid UsuarioId { get; private set; }
        public CategoriaNome Nome { get; private set; }
        public TipoTransacao TipoTransacao { get; private set; }
        public Descricao Descricao { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataAtualizacao { get; private set; }
        public Usuario? Usuario { get; private set; }
    }
}