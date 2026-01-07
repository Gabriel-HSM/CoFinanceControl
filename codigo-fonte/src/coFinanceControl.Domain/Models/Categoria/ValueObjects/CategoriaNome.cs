namespace CoFinanceControl.Domain.Models.Categoria.ValueObjects
{
    public readonly record struct CategoriaNome
    {
        public string Valor { get;}

        public CategoriaNome(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException("O nome da categoria não deve ser vazio", nameof(valor));
            }

             if (valor.Length < 3 || valor.Length > 50)
            {
                throw new ArgumentException("O primeiro nome deve ter entre 3 e 50 caracteres.", nameof(valor));
            }

            //Verificação simples para implementação robusta no futuro
            if (valor.Contains(".") || valor.Contains(",") || valor.Contains(";") || valor.Contains(":") || valor.Contains("!") || valor.Contains("?") || valor.Contains("-") || valor.Contains("_"))
            {
                throw new ArgumentException("O primeiro nome não deve conter caracteres especiais.", nameof(valor));
            }

            Valor = valor;
        }
        public override string ToString() => Valor;
        public static implicit operator string(CategoriaNome nome) => nome.Valor;
    }
}