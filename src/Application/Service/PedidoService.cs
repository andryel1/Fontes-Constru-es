using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service;

public class PedidoService : IPedidoService
{
    private readonly IPedidoService _pedidoService;

    public PedidoService(IPedidoService pedidoService)
    {
        _pedidoService = pedidoService;
    }

    // IInterfaceBaseRepository<PedidoDto, Pedido>
    public Task<PedidoDto> Adicionar(PedidoDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<PedidoDto> Atualizar(PedidoDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Deletar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<PedidoDto> ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<PedidoDto>> ObterTodos()
    {
        throw new NotImplementedException();
    }

    // IPedidoRepository
    public Task<IEnumerable<PedidoDto>> ObterPedidosPorClienteId(Guid clienteId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AtualizarStatusPedido(Guid pedidoId, string novoStatus)
    {
        throw new NotImplementedException();
    }
}
