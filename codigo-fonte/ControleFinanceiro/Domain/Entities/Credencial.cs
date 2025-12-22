
namespace ControleFinanceiro.Domain.Entities
{
    public class Credencial
    {
        public int Id { get; private set; }
        public string? Email { get; private set; }
        public string? Senha { get; set; }
        public string? google_id { get; private set; }
        public required int IdUsuario { get; set; }
        public required Usuario Usuario { get; set; }
        
    }
}