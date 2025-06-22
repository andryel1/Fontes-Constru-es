using Ecommerce.Domain.Entities;
using System.Collections.Generic;

namespace Application.Dtos
{
    public record CategoriaDto(
         string Nome,
         List<Produto> Produtos
    );
}