using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service;

public class PedidoService(IPedidoService pedidoService) : IPedidoService
{
    private readonly IPedidoService _pedidoService = pedidoService;

public Task<PedidoDto> Adicionar(PedidoDto dto)
{

    if (dto.Valor <= 0)
    {
        throw new ArgumentException("O campo 'Valor' do PedidoDto deve ser maior que zero.", nameof(dto));
    }
    if (dto.DataPagamento == DateTime.MinValue)
    {
        throw new ArgumentException("O campo 'DataPagamento' do PedidoDto não pode ser uma data vazia.", nameof(dto));
    }
    if(string.IsNullOrWhiteSpace(dto.Status))
    {
        throw new ArgumentException("O campo 'Status' do PedidoDto não pode ser nulo ou vazio.", nameof(dto));
    }
    if(dto.Pedidos == null || !dto.Pedidos.Any())
    {
        throw new ArgumentException("O PedidoDto deve conter pelo menos um item no campo 'Pedidos'.", nameof(dto));
    }

    return _pedidoService.Adicionar(dto);
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
