using Application.Dtos;
using Ecommerce.Domain.Entities;


namespace Application.Interfaces.Repository;

public interface IDetalhePedidoRepository : IInterfaceBaseRepository<DetalhePedidoDto, DetalhePedido>
{
    Task<DetalhePedidoDto> ObterDetalhePedidoPorId(int id);
    Task<IEnumerable<DetalhePedidoDto>> ObterDetalhesPedidoPorPedidoId(int pedidoId);

}