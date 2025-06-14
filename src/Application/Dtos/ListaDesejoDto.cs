using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record ListaDesejoDto(
    DateTime DataAdicionada,
    required List<Produto> Produtos,
    required Cliente Clientes
);