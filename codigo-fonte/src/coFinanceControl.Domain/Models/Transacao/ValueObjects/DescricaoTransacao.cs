namespace CoFinanceControl.Domain.Models.Transacao.ValueObjects
{
    public readonly record struct DescricaoTransacao
    {
        public string Valor { get;}

        public DescricaoTransacao(string valor)
        {
            if(string.IsNullOrWhiteSpace(valor))
                throw new ArgumentException("A descrição não pode ser vazia.");

            if(valor.Length > 250)
                throw new ArgumentException("A descrição não pode exceder 250 caracteres.");

            Valor = valor;
        }
        public override string ToString() => Valor;
        public static implicit operator string(DescricaoTransacao descricao) => descricao.Valor;
        
    }
}