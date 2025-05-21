using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public class TagDto
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required List<Produto> Produtos { get; set; } 
}