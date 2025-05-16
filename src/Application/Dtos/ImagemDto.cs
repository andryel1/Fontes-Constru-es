using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public class ImagemDto
{
    public int Id { get; set; }
    public required Uri Url { get; set; }
    public required Produto Produto { get; set; }
}