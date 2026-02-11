using CoFinanceControl.Domain.Enums;

namespace CoFinanceControl.Domain.Models.ContaFinanceira
{
    public sealed class ContaFinanceira
    {
        public Guid Id { get; set; } 
        public TipoConta TipoConta { get; set; } 
        public bool Ativa { get; set; } 
        public DateTime DataCriacao { get; set; } 
        
        private ContaFinanceira() {}

        public ContaFinanceira(TipoConta tipoConta)
        {
            TipoConta = tipoConta;
            Ativa = true;
            DataCriacao = DateTime.UtcNow;
        }

        public void Desativar()
        {
            Ativa = false;
        }
    }
}