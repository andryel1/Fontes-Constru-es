using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public class UsuarioDto
{
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Cliente? Cliente { get; set; }
        public Administrador? Administrador { get; set; }
}