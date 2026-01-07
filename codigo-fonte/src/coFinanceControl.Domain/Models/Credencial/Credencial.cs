using CoFinanceControl.Domain.Models.Credencial.ValueObjects;

namespace CoFinanceControl.Domain
{
    public class Credencial
    {
        public Guid Id { get; private set; }
        public Guid UsuarioId { get; private set; }
        public Email Email { get; private set; }
        public Senha Senha { get; private set; }

        public required Usuario Usuario { get; set; }

    }
}