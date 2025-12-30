namespace CoFinanceControl.Domain
{
    public class Credencial
    {
        public Guid Id { get; set; }
        public Guid IdUsuario { get; set; }
        public required string Email { get; set; }
        public required string Senha { get; set; }

        public required Usuario Usuario { get; set; }

        
    }
}