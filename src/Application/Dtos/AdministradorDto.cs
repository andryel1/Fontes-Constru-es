using System;
using Ecommerce.Domain.Entities;

namespace Application.Dtos;
public record AdministradorDto(
    int Id,
    string UserNome,
    string Password,
    string Email,
    DateTime DataNascimento,
    Usuario Usuarios
);