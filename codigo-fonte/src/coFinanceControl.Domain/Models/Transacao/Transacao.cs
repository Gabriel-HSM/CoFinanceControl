using CoFinanceControl.Domain.Enums;
using CoFinanceControl.Domain.Models.Transacao.ValueObjects;

namespace CoFinanceControl.Domain.Models.Transacao
{
    public class Transacao
    {
        public Guid Id { get; private set; }
        public Guid UsuarioId { get; private set; }
        public Guid CategoriaId { get; private set; }
        public TipoTransacao TipoTransacao { get; private set; }
        public DateTime DataTransacao { get; private set; }
        public DescricaoTransacao Descricao { get; private set; }
        
    }
}