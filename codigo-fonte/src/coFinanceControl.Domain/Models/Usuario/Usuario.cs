using CoFinanceControl.Domain.Models.Usuario.ValueObects;

namespace CoFinanceControl.Domain.Models.Usuario
{
    //sealed pra evitar herança e manter integridade.
    public sealed class Usuario
    {
        public int Id { get; private set; }
        public PrimeiroNome Nome { get; private set; }
        public Sobrenome Sobrenome { get; private set; }
        

        
    }
}