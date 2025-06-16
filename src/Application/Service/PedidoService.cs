using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service;

public class PedidoService(IPedidoService pedidoService) : IPedidoService
{
    private readonly IPedidoService _pedidoService = pedidoService;

    public async Task<IEnumerable<PedidoDto>> ObterPedidosPorClienteId(Guid clienteId)
    {
        return await _pedidoService.ObterPedidosPorClienteId(clienteId);
    }

    public async Task<bool> AtualizarStatusPedido(Guid pedidoId, string novoStatus)
    {
        return await _pedidoService.AtualizarStatusPedido(pedidoId, novoStatus);
    }

    public async Task<PedidoDto> Adicionar(PedidoDto dto)
    {
        return await _pedidoService.Adicionar(dto);
    }

    public async Task<PedidoDto> Atualizar(PedidoDto dto)
    {
        return await _pedidoService.Atualizar(dto);
    }

    public async Task<bool> Deletar(int id)
    {
        return await _pedidoService.Deletar(id);
    }

    public async Task<PedidoDto> ObterPorId(int id)
    {
        return await _pedidoService.ObterPorId(id);
    }

    public async Task<List<PedidoDto>> ObterTodos()
    {
        return await _pedidoService.ObterTodos();
    }
}