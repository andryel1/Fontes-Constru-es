using Application.Dtos;
using Ecommerce.Domain.Entities;


namespace Application.Interfaces.Repository;
public interface IDetalhePedidoRepository
{
    Task<DetalhePedidoDto> AdicionarDetalheDoPedido(DetalhePedidoDto detalheDoPedido);
    Task<DetalhePedidoDto> AtualizarDetalheDoPedido(DetalhePedidoDto detalheDoPedido);
    Task<bool> DeletarDetalheDoPedido(int id);
    Task<DetalhePedidoDto> ObterDetalheDoPedidoPorId(int id);
    Task<List<DetalhePedidoDto>> ObterTodosDetalhesDoPedido();
}