using Ecommerce.Domain.Entities;

namespace Application.Dtos
{
    public class CategoriaDto
    {
        public required string Nome;
        public required List<Produto> Produtos { get; set; } 
    }
}