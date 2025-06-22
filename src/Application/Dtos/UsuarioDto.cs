using System;
using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record UsuarioDto(
        int Id,
        string UserName,
        string Password,
        string Email,
        DateTime DataNascimento,
        Cliente? Cliente,
        Administrador? Administrador
);
