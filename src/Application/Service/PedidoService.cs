using Application.Interfaces.Service;
using Application.Dtos;
using System.Linq;

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

    public Task<PedidoDto> Atualizar(PedidoDto dto)
    {
        throw new NotImplementedException();
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
