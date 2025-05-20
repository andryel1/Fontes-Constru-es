using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Dtos
{
    public class CategoriaDto
    {
        public required string Nome;
        public required List<Produto> Produtos { get; set; } 
    }
}