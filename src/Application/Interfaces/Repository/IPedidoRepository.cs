using Application.Dtos;
using Ecommerce.Domain.Entities;

namespace Application.Interfaces.Repository;

public interface IPedidoRepository : IInterfaceBaseRepository<PedidoDto, Pedido>
{
    Task<IEnumerable<PedidoDto>> ObterPedidosPorClienteId(Guid clienteId);
    Task<bool> AtualizarStatusPedido(Guid pedidoId, string novoStatus);
}