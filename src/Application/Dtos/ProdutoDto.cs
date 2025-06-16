using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record ProdutoDto(
    int Id,
    string Nome,
    string Descricao,
    string Estoque,
    decimal Preco,
    List<Imagem> Imagens,
    List<Avaliacao> Avaliacoes,
    List<ItemCarrinho> ItensCarrinho,
    List<Pedido> Pedidos,
    List<ListaDesejo> ListaDesejos,
    List<Categoria> Categorias,
    List<Tag> Tags
);