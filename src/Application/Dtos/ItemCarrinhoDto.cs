using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record ItemCarrinhoDto(
    int Id,
    int ProdutoId,
    int Quantidade,
    decimal Preco,
    Produto Produto,
    Carrinho Carrinho,
    int CarrinhoId
);