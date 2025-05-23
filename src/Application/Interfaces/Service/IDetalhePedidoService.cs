using Application.Interfaces.Repository;

namespace Application.Interfaces.Services
{
    public interface IDetalhePedidoService : IDetalhePedidoRepository
    {
    Task<bool> VerificarSeProdutoJaFoiAdicionadoAoPedido(int pedidoId, Guid produtoId);
    Task<bool> VerificarSeProdutoJaFoiAdicionadoAoCarrinho(Guid produtoId);
    Task<bool> VerificarSeProdutoJaFoiAdicionadoAoCarrinhoPorId(int id);
    }
}