using Ecommerce.Domain.Entities;

namespace Application.Dtos;
public record ClienteDto(
    int Id,
    string Nome,
    int Cpf,
    string Password,
    string Telefone,
    string Email,
    DateTime DataNascimento,
    Usuario? Usuarios
);