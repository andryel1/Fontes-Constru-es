using Ecommerce.Domain.Entities;

namespace Application.Dtos;
public class AdministradorDto
{
       public required string UserNome { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public required Usuario Usuarios { get; set; }
}