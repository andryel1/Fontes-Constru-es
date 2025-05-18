namespace Ecommerce.Domain.Entities
{
    public class Administrador : Entitybase
    {
        public required string UserNome { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public required Usuario Usuarios { get; set; }
    }
}