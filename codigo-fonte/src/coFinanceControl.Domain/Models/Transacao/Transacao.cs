using CoFinanceControl.Domain.Models.Transacao.ValueObjects;
using CoFinanceControl.Domain.Models.Rateios;
namespace CoFinanceControl.Domain.Models.Transacao
{
    public sealed class Transacao
    {
        public int Id { get; private set; }
        public Guid UsuarioId { get; private set; }
        public TransacaoValor ValorTotal { get; private set; }
        public TransacaoDescricao Descricao { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataAtualizacao { get; private set; }
        private readonly List<Rateio> _rateios = new();
        public IReadOnlyCollection<Rateio> Rateios => _rateios;

        private Transacao(){}

        public static Transacao Criar(Guid usuarioId, TransacaoValor valor, TransacaoDescricao descricao)
        {
            return new Transacao
            {
                UsuarioId = usuarioId,
                ValorTotal = valor,
                Descricao = descricao,
                DataCriacao = DateTime.UtcNow
            };
        }

        public void Atualizar(TransacaoValor valor, TransacaoDescricao descricao)
        {

            ValorTotal = valor;
            Descricao = descricao;
            DataAtualizacao = DateTime.UtcNow;
        }

        public void DefinirRateios(IEnumerable<( int categoriaId, DestinoRateio destino, ValorRateio valor)> rateios)
        {
            _rateios.Clear();

            foreach (var r in rateios)
            {
                _rateios.Add(new Rateio(
                    transacaoId: Id,
                    destino: r.destino,
                    categoriaId: r.categoriaId,
                    valor: r.valor
                ));
            }
        }
    }
}