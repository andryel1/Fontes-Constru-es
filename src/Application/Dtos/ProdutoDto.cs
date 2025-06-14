using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record ProdutoDto(
    int Id,
    required string Nome,
    required string Descricao,
    required string Estoque,
    required decimal Preco,
    required List<Imagem> Imagens,
    required List<Avaliacao> Avaliacoes,
    required List<ItemCarrinho> ItensCarrinho,
    required List<Pedido> Pedidos,
    required List<ListaDesejo> ListaDesejos,
    required List<Categoria> Categorias,
    required List<Tag> Tags
);