
namespace ControleFinanceiro.Domain.Entities
{
    public class Transacao
    {
        public Guid Id { get; private set; }
        public Guid UsuarioId { get; private set; }
        public Guid CategoriaId { get; private set; }
        public Guid ContaId { get; private set; }

        public decimal Valor { get; private set; }
        public DateTime Data { get; private set; }
        public string Tipo { get; private set; } // Entrada ou Saida
        public string Descricao { get; private set; }

        //Classes e subclasses de entidade necessitam de um construtor protegido sem parâmetros para o EF Core
        protected Transacao() { }

        //Construtor
        public Transacao(
            Guid usuarioId, 
            Guid categoriaId, 
            Guid contaId, 
            decimal valor, 
            DateTime data, 
            string tipo, 
            string descricao)
        {
            
            if (valor <= 0)
            throw new ArgumentException("Valor deve ser maior que zero.");

            if (tipo != "entrada" && tipo != "saida")
                throw new ArgumentException("tipo invalido");

            Id = Guid.NewGuid();
            UsuarioId = usuarioId;
            CategoriaId = categoriaId;
            ContaId = contaId;
            Valor = valor;
            Data = data;
            Tipo = tipo;
            Descricao = descricao;
        }

    }
}