using Application.Dtos;
using Application.Interfaces.Repository;
using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class DescontoRepository : IDescontoRepository
{
    private readonly Context _context;

    public DescontoRepository(Context context)
    {
        _context = context;
    }

    public async Task<DescontoDto> ObterDescontoPorId(int id)
    {
        var desconto = await _context.Descontos.FindAsync(id);
        if (desconto == null)
        {
            return null!;
        }
        return new DescontoDto(
            desconto.Id,
            (decimal)desconto.Valor,
            desconto.DataInicio,
            desconto.DataFim,
            desconto.Produtos.ToList(),
            desconto.ProdutoId,
            desconto.Ativo
        );
    }

    public async Task<IEnumerable<DescontoDto>> ObterDescontosAtivos()
    {
        var Desconto = await _context.Descontos.ToListAsync();
        return Desconto.Select(p => new DescontoDto(
            p.Id,
            (decimal)p.Valor,
            p.DataInicio,
            p.DataFim,
            p.Produtos.ToList(),
            p.ProdutoId,
            p.Ativo
        ));
    }

    public Task<IEnumerable<DescontoDto>> ObterDescontosInativos()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DescontoDto>> ObterDescontosExpirados()
    {
        throw new NotImplementedException();
    }

    public Task<DescontoDto> Adicionar(DescontoDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<DescontoDto> Atualizar(DescontoDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Deletar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DescontoDto> ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<DescontoDto>> ObterTodos()
    {
        throw new NotImplementedException();
    }
}