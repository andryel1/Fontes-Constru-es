using Application.Interfaces.Repository;
using Ecommerce.Domain.Entities;
using Application.Dtos;

namespace Infrastructure.Repositories;

public class DetalhePedidoRepository(Context context) : IDetalhePedidoRepository
{
    private readonly Context _context = context;
    public async Task<DetalhePedidoDto> Adicionar(DetalhePedidoDto entity)
    {
        var detalhePedido = new DetalhePedido
        {
            PedidoId = entity.PedidoId,
        };
        _context.Add(detalhePedido);
        await _context.SaveChangesAsync();
        return entity;
    }

    public Task<DetalhePedidoDto> Atualizar(DetalhePedidoDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Deletar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DetalhePedidoDto> ObterDetalhePedidoPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DetalhePedidoDto>> ObterDetalhesPedidoPorPedidoId(int pedidoId)
    {
        throw new NotImplementedException();
    }

    public Task<DetalhePedidoDto> ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<DetalhePedidoDto>> ObterTodos()
    {
        throw new NotImplementedException();
    }
}