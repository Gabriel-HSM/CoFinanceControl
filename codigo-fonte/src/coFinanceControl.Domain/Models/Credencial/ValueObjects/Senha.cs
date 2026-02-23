using System.Text.RegularExpressions;

namespace CoFinanceControl.Domain.Models.Credencial.ValueObjects
{
    public readonly record struct Senha
    {
        private static readonly Regex RegexSenha = new (@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$", RegexOptions.Compiled);
        public string Valor { get; }

        public Senha(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new ArgumentException("A senha não pode ser vazia", nameof(valor));
            }

            if (!RegexSenha.IsMatch(valor))
            {
                throw new ArgumentException("A senha deve ter no mínimo 8 caracteres, incluindo maiúscula, minúscula, número e caractere especial.", nameof(valor));
            }

            Valor = valor;
        }
        public override string ToString() => Valor;
        public static implicit operator string(Senha senha) => senha.Valor; 
    }
}