namespace CoFinanceControl.Domain.Models.Transacao.ValueObjects
{
    public readonly record struct TransacaoDescricao
    {
        public string Valor { get; }

        public TransacaoDescricao(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor)){
                throw new ArgumentNullException(nameof(valor), "A descrição não deve estar vazia");
            }

            var descricaoFormatada = valor.Trim();
            
            if (descricaoFormatada.Length < 5)
            {
                throw new ArgumentOutOfRangeException("A descrição não deve ter menos de 5 caracteres", nameof(valor));
            }

            if (descricaoFormatada.Length > 155)
            {
                throw new ArgumentOutOfRangeException("A descrição não deve ter mais de 155 caracteres", nameof(valor));
            }

            Valor = valor.Trim();
        }

        public override string ToString() => Valor;
        public static implicit operator string(TransacaoDescricao descricao) => descricao.Valor;
        
    }
}