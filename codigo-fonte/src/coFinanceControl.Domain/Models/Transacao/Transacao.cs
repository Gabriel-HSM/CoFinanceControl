using CoFinanceControl.Domain.Enums;
using CoFinanceControl.Domain.Models.Transacao.ValueObjects;

namespace CoFinanceControl.Domain
{
    public class Transacao
    {
        public Guid Id { get; private set; }
        public Guid UsuarioId { get; private set; }
        public ICollection<Categoria> Categorias {get; private set;} = new List<Categoria>();
        public TipoTransacao TipoTransacao { get; private set; }
        public ValorTransacao ValorTransacao { get; private set; }
        public DateTime DataTransacao { get; private set; }
        public DescricaoTransacao Descricao { get; private set; }
        public DateTime DataAtualizacao { get; private set; }

        //Construtor vazio, pois as validações são feitas nos serviços e nos Value Objects
        private Transacao() { }

        public static Transacao CriarTransacao(Guid usuarioId, Categoria categoria, TipoTransacao tipoTransacao, ValorTransacao valorTransacao, DateTime dataTransacao, DescricaoTransacao descricao)
        {
            var transacao = new Transacao
            {
                Id = Guid.NewGuid(),
                UsuarioId = usuarioId,
                TipoTransacao = tipoTransacao,
                ValorTransacao = valorTransacao,
                DataTransacao = dataTransacao,
                Descricao = descricao,
            };

            if (categoria is not null)
            {
                transacao.AdicionarCategoria(categoria);
            }

            return transacao;
        }

        public void AtualizarTransacao(ICollection<Categoria> categorias, TipoTransacao tipoTransacao, ValorTransacao valorTransacao, DateTime dataTransacao, DescricaoTransacao descricao)
        {
            Categorias = categorias;
            TipoTransacao = tipoTransacao;
            ValorTransacao = valorTransacao;
            DataTransacao = dataTransacao;
            Descricao = descricao;
            DataAtualizacao = DateTime.UtcNow;
        }

        //Duvida se eu adiciono métodos de adicionar categorias aqui direto na coleção, ou se é em outro lugar (services)
        public void AdicionarCategoria(Categoria categoria)
        {
            if (Categorias.Any(c => c.Id == categoria.Id))
            {
                throw new InvalidOperationException("Categoria já adicionada à transação.");
            }

            Categorias.Add(categoria);
        }

        public void RemoverCategoria(Guid categoriaId)
        {
            var categoria = Categorias.SingleOrDefault(c => c.Id == categoriaId);
            if (categoria is null)
            {
                throw new InvalidOperationException("Categoria não encontrada.");
            }

            Categorias.Remove(categoria);
        }
    }
}