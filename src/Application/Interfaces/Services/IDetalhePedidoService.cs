using Application.Dtos;
using Ecommerce.Domain.Entities;
using Application.Interfaces.Repository;

namespace Application.Interfaces.Services
{
    public interface IDetalhePedidoService : IInterfaceBaseRepository<DetalhePedidoDto, DetalhePedido>
    {
    Task<bool> VerificarSeProdutoJaFoiAdicionadoAoPedido(int pedidoId, Guid produtoId);
    Task<bool> VerificarSeProdutoJaFoiAdicionadoAoCarrinho(Guid produtoId);
    Task<bool> VerificarSeProdutoJaFoiAdicionadoAoCarrinhoPorId(int id);
    }
}