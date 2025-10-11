using Application.Dtos;
using Application.Interfaces.Repository;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Repositories;

public class PagamentoRepository(Context context) : IPagamentoRepository
{
    private readonly Context _context = context;
    public async Task<PagamentoDto> Adicionar(PagamentoDto entity)
    {
        var pagamento = new Pagamento
        {
            Valor = entity.Valor
        };
        _context.Add(pagamento);
        await _context.SaveChangesAsync();
        return entity;
    }

    public Task<PagamentoDto> Atualizar(PagamentoDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Deletar(int id)
    {
        throw new NotImplementedException();
    }
    public Task<PagamentoDto> ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<PagamentoDto>> ObterTodos()
    {
        throw new NotImplementedException();
    }

    public Task<PagamentoDto> ObterPagamentoPorPedidoId(int pedidoId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> VerificarSePagamentoJaFoiRealizado(int pedidoId)
    {
        throw new NotImplementedException();
    }
}