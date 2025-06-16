using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record ListaDesejoDto
{
    public DateTime DataAdicionada { get; set; }
    public List<Produto>? Produtos { get; set; }
    public Cliente? Clientes { get; set; }
    public int ClienteId{ get; set; }
}