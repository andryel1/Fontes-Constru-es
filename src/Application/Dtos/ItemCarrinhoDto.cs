using Ecommerce.Domain.Entities;

namespace Application.Dtos
{
    public record ItemCarrinhoDto(
        int Quantidade,
        required double Preco,
        required Produto Produto,
        required Carrinho Carrinho,
        int CarrinhoId,
        int ProdutoId
    );
}