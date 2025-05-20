using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public class CategoriaDto
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public List<Produto> Produtos { get; set; } = new();
}