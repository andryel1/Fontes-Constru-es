using Ecommerce.Domain.Entities;

namespace Application.Dtos;
public record ClienteDto(

    int Id,
    string Nome,
    string Cpf,
    string Password,
    string Telefone,
    string Email,
    DateTime DataNascimento,
    Usuario? Usuarios
);