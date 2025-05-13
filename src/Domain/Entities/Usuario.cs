
namespace Ecommerce.Domain.Entities
{
    public class Usuario : Entitybase
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Cliente? Cliente { get; set; }
        public Administrador? Administrador { get; set; }
    }
}
