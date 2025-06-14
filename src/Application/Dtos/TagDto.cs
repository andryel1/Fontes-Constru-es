using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record TagDto(
    int Id,
    required string Nome,
    required List<Produto> Produtos
);