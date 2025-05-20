using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public class DescontoDto
{
    public required string Nome { get; set; }
    public required decimal Valor { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public bool Ativo { get; set; } = true;
    public required List<Produto> Produtos { get; set; }
     public int ProdutoId { get; set; }
}