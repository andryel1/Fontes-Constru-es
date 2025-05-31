using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service;

public class PedidoService(IPedidoService pedidoService) : IPedidoService
{
    private readonly IPedidoService _pedidoService = pedidoService;

public async Task<PedidoDto> Adicionar(PedidoDto dto)
{
    if (dto.Valor <= 0)
    {
        throw new ArgumentException("O campo 'Valor' do PedidoDto deve ser maior que zero.");
    }
    if (dto.DataPagamento == DateTime.MinValue)
    {
        throw new ArgumentException("O campo 'DataPagamento' do PedidoDto não pode ser uma data vazia.");
    }
    if (string.IsNullOrWhiteSpace(dto.Status))
    {
        throw new ArgumentException("O campo 'Status' não pode ser nulo ou vazio no objeto PedidoDto.");
    }

    if(dto.Pedidos == null || dto.Pedidos.Count == 0)
    {
        throw new ArgumentException("O PedidoDto deve conter pelo menos um item no campo 'Pedidos'.");
    }
    return await _pedidoService.Adicionar(dto);
}
public async Task<PedidoDto> Atualizar(PedidoDto dto)
{
    if (dto.Id <= 0)
    {
        throw new ArgumentException("O ID do PedidoDto deve ser maior que zero.");
    }

    var pedidoExistente = await _pedidoService.ObterPorId(dto.Id)
    ?? throw new KeyNotFoundException($"PedidoDto com ID {dto.Id} não encontrado.");

        dto.Id = pedidoExistente.Id;

    if (dto.Valor <= 0)
    {
        throw new ArgumentException("O campo 'Valor' do Pedido deve ser maior que zero.");
    }
    if (dto.DataPagamento == DateTime.MinValue)
    {
        throw new ArgumentException("O campo 'DataPagamento' do PedidoDto não pode ser uma data vazia.");
    }
    if (string.IsNullOrWhiteSpace(dto.Status))
    {
        throw new ArgumentException("O campo 'Status' não pode ser nulo ou vazio no objeto PedidoDto.");
    }
    if (dto.Pedidos == null || dto.Pedidos.Count == 0)
    {
        throw new ArgumentException("O PedidoDto deve conter pelo menos um item no campo 'Pedidos'.");
    }

    return await _pedidoService.Atualizar(dto);
}
    public async Task<bool> Deletar(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("O ID do PedidoDto deve ser maior que zero.");
        }
        if (_pedidoService.ObterPorId(id) == null)
        {
            throw new KeyNotFoundException($"PedidoDto com ID {id} não encontrado.");
        }
        return await _pedidoService.Deletar(id);   
    }

    public async Task<PedidoDto> ObterPorId(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("O ID do PedidoDto deve ser maior que zero.");
        }
        return await _pedidoService.ObterPorId(id);
    }

    public async Task<List<PedidoDto>> ObterTodos()
    {
        return await _pedidoService.ObterTodos();
    }

    // IPedidoRepository
    public async Task<IEnumerable<PedidoDto>> ObterPedidosPorClienteId(Guid clienteId)
    {
        if (clienteId == Guid.Empty)
        {
            throw new ArgumentException("Não pode ser vazio.");
        }
        return await _pedidoService.ObterPedidosPorClienteId(clienteId);
    }

  public async Task<bool> AtualizarStatusPedido(Guid pedidoId, string novoStatus)
{
    if (pedidoId == Guid.Empty)
    {
        throw new ArgumentException("O Id do pedido não pode ser vazio.");
    }

    if (string.IsNullOrWhiteSpace(novoStatus))
    {
        throw new ArgumentException("O novo status não pode ser nulo ou vazio.");
    }

    return await _pedidoService.AtualizarStatusPedido(pedidoId, novoStatus);
}

}
