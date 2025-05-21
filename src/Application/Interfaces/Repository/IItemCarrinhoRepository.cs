using Ecommerce.Domain.Entities;
using Application.Dtos;

namespace Application.Interfaces.Repository;

public interface IItemCarrinhoRepository : IInterfaceBaseRepository<ItemCarrinhoDto, ItemCarrinho>
{
    Task<ItemCarrinhoDto> ObterItemCarrinhoPorId(Guid id);
    Task<ItemCarrinhoDto> ObterItemCarrinhoPorIdProduto(Guid idProduto);
}
