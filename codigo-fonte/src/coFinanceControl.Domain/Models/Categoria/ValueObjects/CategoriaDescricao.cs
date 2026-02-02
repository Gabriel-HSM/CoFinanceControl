namespace CoFinanceControl.Domain.Models.Categoria.ValueObjects
{
    public readonly record struct CategoriaDescricao
    {
        public string Valor { get; }

        public CategoriaDescricao(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException("A descrição não deve ser vazia", nameof(valor));
            }

            var categoriaNomeFormatado = valor.Trim();

            if (categoriaNomeFormatado.Length > 155)
            {
                throw new ArgumentException("A descrição não pode exceder 155 caracteres", nameof(valor));
            }

            if (categoriaNomeFormatado.Length < 7)
            {
                throw new ArgumentException("A descrição não pode ser menor que 7 caracteres", nameof(valor));
            }

            Valor = valor;
        }
        public override string ToString() => Valor;
        public static implicit operator string(CategoriaDescricao categoriaDescricao) => categoriaDescricao.Valor;
    }
}