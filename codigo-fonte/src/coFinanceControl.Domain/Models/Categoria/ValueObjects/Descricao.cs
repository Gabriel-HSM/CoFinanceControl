namespace CoFinanceControl.Domain.Models.Categoria.ValueObjects
{
    public readonly record struct Descricao
    {
        public string Valor { get;}

        public Descricao(string valor)
        {
            if(string.IsNullOrWhiteSpace(valor))
                throw new ArgumentException("A descrição não pode ser vazia.");

            if(valor.Length > 250)
                throw new ArgumentException("A descrição não pode exceder 250 caracteres.");

            Valor = valor;
        }
        public override string ToString() => Valor;
        public static implicit operator string(Descricao descricao) => descricao.Valor;
    }
}