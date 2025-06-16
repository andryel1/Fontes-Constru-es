using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record TagDto(
    int Id,
    string Nome,
    List<Produto> Produtos
);