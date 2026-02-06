using System.Text.RegularExpressions;

namespace CoFinanceControl.Domain.Models.Categoria.ValueObjects
{
    public readonly record struct CategoriaDescricao
    {
        private static Regex RegexNome = new (@"^[A-Za-zÀ-ÖØ-öø-ÿ0-9 ]+$");
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

            if (categoriaNomeFormatado.Length < 3)
            {
                throw new ArgumentException("A descrição não pode ser menor que 3 caracteres", nameof(valor));
            }

            if (!RegexNome.IsMatch(valor))
            {
                throw new ArgumentException("Nome contém caracteres inválidos");      
            }

            Valor = valor;
        }
        public override string ToString() => Valor;
        public static implicit operator string(CategoriaDescricao categoriaDescricao) => categoriaDescricao.Valor;
    }
}