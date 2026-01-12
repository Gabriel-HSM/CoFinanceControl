using CoFinanceControl.Domain.Enums;
using CoFinanceControl.Domain.Models.Transacao.ValueObjects;

namespace CoFinanceControl.Domain
{
    public class Transacao
    {
        public Guid Id { get; private set; }
        public Guid UsuarioId { get; private set; }
        //Adicioanar no futuro a possibilidade de adicionar mais de uma categoria com Icollection 
        public Guid CategoriaId { get; private set; }
        public TipoTransacao TipoTransacao { get; private set; }
        public ValorTransacao ValorTransacao { get; private set; }
        public DateTime DataTransacao { get; private set; }
        public DescricaoTransacao Descricao { get; private set; }
        public DateTime DataAtualizacao { get; private set; }

        //Construtor vazio, pois as validações são feitas nos serviços e nos Value Objects
        private Transacao() { }

        public static Transacao CriarTransacao(Guid usuarioId, Guid categoriaId, TipoTransacao tipoTransacao, ValorTransacao valorTransacao, DateTime dataTransacao, DescricaoTransacao descricao)
        {
            return new Transacao
            {
                Id = Guid.NewGuid(),
                UsuarioId = usuarioId,
                CategoriaId = categoriaId,
                TipoTransacao = tipoTransacao,
                ValorTransacao = valorTransacao,
                DataTransacao = dataTransacao,
                Descricao = descricao,
            };
        }

        public void AtualizarTransacao(Guid categoriaId, TipoTransacao tipoTransacao, ValorTransacao valorTransacao, DateTime dataTransacao, DescricaoTransacao descricao)
        {
            TipoTransacao = tipoTransacao;
            ValorTransacao = valorTransacao;
            DataTransacao = dataTransacao;
            Descricao = descricao;
            CategoriaId = categoriaId;
            DataAtualizacao = DateTime.UtcNow;
        }
    }
}