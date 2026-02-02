namespace CoFinanceControl.Domain.Models.Categoria.ValueObjects
{
    public readonly record struct CategoriaNome
    {
        public string Valor { get; }

        public CategoriaNome(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException("O nome da categoria não deve ser vazio", nameof(valor));
            }

            var categoriaNomeFormatado = valor.Trim();

            if (categoriaNomeFormatado.Length > 30)
            {
                throw new ArgumentException("O nome da categoria não pode exceder 30 caracteres", nameof(valor));
            }

            if (categoriaNomeFormatado.Length < 3)
            {
                throw new ArgumentException("O nome da categoria não pode ser menor que 3 caracteres", nameof(valor));
            }

             Valor = valor;
        }

        public override string ToString() => Valor;

        public static implicit operator string(CategoriaNome categoriaNome) => categoriaNome.Valor;
    }
}