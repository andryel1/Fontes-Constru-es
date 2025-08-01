using Domain.Enums;

namespace Ecommerce.Domain.Entities
{
    public class Usuario : Entitybase
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Cliente? Cliente { get; set; }
        public int ClienteId { get; set; }
        public Administrador? Administrador { get; set; }
        public int AdministradorId { get; set; }
        public Perfil Perfil { get; set; }
    }
}
