namespace Ecommerce.Domain.Entities
{
    public class Administrador : Entitybase
    {
        public string? UserNome { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Usuario? Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}