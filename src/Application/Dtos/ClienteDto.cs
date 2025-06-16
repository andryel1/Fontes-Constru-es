using Ecommerce.Domain.Entities;

namespace Application.Dtos;
public record ClienteDto(
    required string Nome,
    required int Cpf,
    required string Password,
    required string Telefone,
    required string Email,
    DateTime DataNascimento,
    Usuario? Usuarios
);