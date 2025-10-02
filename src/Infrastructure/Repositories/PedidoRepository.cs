using Application.Dtos;
using Application.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Repositories;

public class PedidoRepository(Context context) : IPedidoRepository
{
    private readonly Context _context = context;
     async Task<PedidoDto> IInterfaceBaseRepository<PedidoDto, Pedido>.Adicionar(PedidoDto entity)
    {
        var produto = new Pedido
        {
            Id = entity.Id,
            DataPedido = entity.DataPedido,
            Status = entity.Status,
            Clientes = entity.Clientes,
            DataEnvio = entity.DataEnvio,
            DataEntrega = entity.DataEntrega,
            Pagamentos = entity.Pagamentos,
            InformacoesEnvio = entity.InformacoesEnvio

        };
        await _context.Pedidos.AddAsync(produto);
        await _context.SaveChangesAsync();
        return entity;
    }

    Task<PedidoDto> IInterfaceBaseRepository<PedidoDto, Pedido>.Atualizar(PedidoDto entity)
    {
        throw new NotImplementedException();
    }

    Task<bool> IPedidoRepository.AtualizarStatusPedido(Guid pedidoId, string novoStatus)
    {
        throw new NotImplementedException();
    }

    async Task<bool> IInterfaceBaseRepository<PedidoDto, Pedido>.Deletar(int id)
    {
        var pedido = await _context.Pedidos.FindAsync(id);
        if (pedido == null) return false;
        _context.Pedidos.Remove(pedido);
        await _context.SaveChangesAsync();
        return true;
        
    }

    async Task<IEnumerable<PedidoDto>> IPedidoRepository.ObterPedidosPorClienteId(int clienteId)
    {
      var pedidos = await _context.Pedidos
    .Where(p => p.ClienteId == clienteId)
    .Select(p => new PedidoDto(
        p.Id,
        p.DataPedido,
        p.Status,
        p.ValorTotal,
        p.Itens,
        p.ClienteId,
        p.DataEnvio,
        p.DataEntrega,
        p.Pagamentos,
        p.InformacoesEnvio
    ))
    .ToListAsync();
    return pedidos;

    }

    Task<PedidoDto> IInterfaceBaseRepository<PedidoDto, Pedido>.ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<PedidoDto>> IInterfaceBaseRepository<PedidoDto, Pedido>.ObterTodos()
    {
        throw new NotImplementedException();
    }
}