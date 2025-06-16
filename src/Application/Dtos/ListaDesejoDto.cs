using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record ListaDesejoDto(
    DateTime DataAdicionada,
    List<Produto> Produtos,
    Cliente Clientes,
    int ClienteId
);