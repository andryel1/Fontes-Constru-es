using Ecommerce.Domain.Entities;

namespace Application.Dtos
{
    public record CategoriaDto(
        required string Nome,
        required List<Produto> Produtos
    );
}