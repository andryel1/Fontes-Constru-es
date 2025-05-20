
namespace Application.Dtos;

public class ImagemDto
{
    public int Id { get; set; }
    public required Uri Url { get; set; }
    public int ProdutoId { get; set; }
}