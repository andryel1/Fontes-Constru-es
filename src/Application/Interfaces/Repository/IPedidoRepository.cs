using Application.Dtos;
using Ecommerce.Domain.Entities;

namespace Application.Interfaces.Repository;

public interface IPedidoRepository : IInterfaceBaseRepository<PedidoDto, Pedido>
{
    Task<bool> AtualizarStatusPedido(Guid pedidoId, string novoStatus);
    Task<IEnumerable<PedidoDto>> ObterPedidosPorClienteId(Cliente clienteId);
}