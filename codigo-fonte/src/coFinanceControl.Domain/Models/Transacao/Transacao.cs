using CoFinanceControl.Domain.Models.Transacao.ValueObjects;

namespace CoFinanceControl.Domain.Models.Transacao
{
    public sealed class Transacao
    {
        public int Id { get; private set; }
        public Guid UsuarioId { get; private set; }
        public Valor ValorTotal { get; private set; }
        public TransacaoDescricao Descricao { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataAtualizacao { get; private set; }

        private Transacao(){}

        // public static Transacao Criar(){}
    }
}