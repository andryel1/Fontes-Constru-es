using Ecommerce.Domain.Entities;

namespace Application.Dtos;
public record ClienteDto(
    string Nome,
    int Cpf,
    string Senha,
    string Telefone,
    string Email,
    DateTime DataNascimento,
    Usuario? Usuarios
);