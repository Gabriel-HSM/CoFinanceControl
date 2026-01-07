namespace CoFinanceControl.Domain.Models.Transacao
{
    public class Transacao
    {
        public Guid Id { get; private set; }
        public Guid UsuarioId { get; private set; }
        public Guid CategoriaId { get; private set; }
        
    }
}