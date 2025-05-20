using Application.Dtos;
using Ecommerce.Domain.Entities;

namespace Application.Interfaces.Repository;

public interface ICarrinhoRepository : IInterfaceBaseRepository<CarrinhoDto, Carrinho>
{
    Task<CarrinhoDto> AdicionarProdutoAoCarrinho(CarrinhoDto carrinho);
    Task<CarrinhoDto> RemoverProdutoDoCarrinho(int produtoId, int usuarioId);
    Task<CarrinhoDto> ObterCarrinhoPorUsuarioId(int usuarioId);
    Task<CarrinhoDto> AtualizarQuantidadeProduto(int produtoId, int usuarioId, int quantidade);
}