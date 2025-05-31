using Ecommerce.Domain.Entities;
using Application.Dtos;
using System.Threading.Tasks;

namespace Application.Interfaces.Repository;

public interface IItemCarrinhoRepository : IInterfaceBaseRepository<ItemCarrinhoDto, ItemCarrinho>
{
    Task<ItemCarrinhoDto> ObterItemCarrinhoPorIdProduto(int idProduto);
}
