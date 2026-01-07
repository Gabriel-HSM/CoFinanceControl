namespace CoFinanceControl.Domain.Models.Credencial.ValueObjects
{

    //não esquecer implementação futura de hash para senha
    public readonly record struct Senha
    {
        public string Valor { get;}

        public Senha(string valor)
        {
            if (valor.Length < 8)
            {
                throw new ArgumentException("A senha deve ter pelo menos 8 caracteres.", nameof(valor));
            }

            if (valor.Count(char.IsUpper) < 2)
            {
                throw new ArgumentException("A senha deve conter pelo menos duas letra maiúscula.", nameof(valor));
            }

            if (valor.Count(char.IsDigit) < 1)
            {
                throw new ArgumentException("A senha deve conter pelo menos um número.", nameof(valor));
            }

            if (valor.Count(char.IsSymbol) + valor.Count(char.IsPunctuation) < 1)
            {
                throw new ArgumentException("A senha deve conter pelo menos um caractere especial.", nameof(valor));
            }

            Valor = valor;
        }
        public override string ToString() => Valor;
        public static implicit operator string(Senha senha) => senha.Valor;
    }
}