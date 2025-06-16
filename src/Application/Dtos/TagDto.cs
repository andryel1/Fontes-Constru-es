using Ecommerce.Domain.Entities;
using System.Collections.Generic;

namespace Application.Dtos;

public record TagDto(
    int Id,
    string Nome,
    List<Produto> Produtos
);