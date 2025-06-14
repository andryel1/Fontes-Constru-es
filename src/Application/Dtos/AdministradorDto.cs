using Ecommerce.Domain.Entities;

namespace Application.Dtos;
public record AdministradorDto(
    required string UserNome,
    required string Password,
    required string Email,
    DateTime DataNascimento,
    required Usuario Usuarios
);