using Ecommerce.Domain.Entities;

namespace Application.Dtos
{
    public record CategoriaDto(
         string Nome,
         List<Produto> Produtos
    );
}