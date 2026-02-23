using CoFinanceControl.Domain.Enums;
using CoFinanceControl.Domain.Models.EntidadeFinanceira.ValueObjects;

namespace CoFinanceControl.Domain.Models.EntidadeFinanceira
{
    public sealed class EntidadeFinanceira
    {
        public Guid Id { get; set; } 
        public EntidadeNome Nome { get; set; }
        public TipoConta TipoConta { get; set; } 
        public bool Ativo { get; set; } 
        public DateTime DataCriacao { get; set; } 
        
        private EntidadeFinanceira() {}

        public EntidadeFinanceira(EntidadeNome nome,TipoConta tipoConta)
        {
            Nome = nome;
            TipoConta = tipoConta;
            Ativo = true;
            DataCriacao = DateTime.UtcNow;
        }

        public void Desativar()
        {
            Ativo = false;
        }
    }
}