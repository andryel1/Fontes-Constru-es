using Application.Dtos;
using Application.Interfaces.Repository;
using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Infrastructure.Repository;

public class DescontoRepository(Context context) : IDescontoRepository
{
    private readonly Context _context = context;

    public async Task<IEnumerable<DescontoDto>> ObterDescontosAtivos()
    {
        var Desconto = await _context.Descontos.ToListAsync();
        return Desconto.Select(p => new DescontoDto(
            p.Id,
            (decimal)p.Valor,
            p.DataInicio,
            p.DataFim,
            [.. p.Produtos],
            p.ProdutoId,
            p.Ativo
        ));
    }

    public async Task<IEnumerable<DescontoDto>> ObterDescontosInativos()
    {
        var DescontoInativo = await _context.Descontos.Where(d => !d.Ativo).ToListAsync();
        return DescontoInativo.Select(p => new DescontoDto(
            p.Id,
            (decimal)p.Valor,
            p.DataInicio,
            p.DataFim,
            [..p.Produtos],
            p.ProdutoId,
            p.Ativo
        ));
    }

    public async Task<IEnumerable<DescontoDto>> ObterDescontosExpirados()
    {
        var now = DateTime.Now;
        var DescontoExpirado = await _context.Descontos.Where(x => x.DataFim < now && x.Ativo).ToListAsync();

        return DescontoExpirado.Select(p => new DescontoDto(
            p.Id,
            (decimal)p.Valor,
            p.DataInicio,
            p.DataFim,
            [..p.Produtos],
            p.ProdutoId,
            p.Ativo
        ));
    }

    public async Task<DescontoDto> Adicionar(DescontoDto entity)
    {
        var desconto = new Desconto
        {
            Valor = (double)entity.Valor,
            DataInicio = entity.DataInicio,
            DataFim = entity.DataFim,
            ProdutoId = entity.ProdutoId,
            Ativo = entity.Ativo
        };

        _context.Descontos.Add(desconto);
        await _context.SaveChangesAsync();

        return new DescontoDto(
            desconto.Id,
            (decimal)desconto.Valor,
            desconto.DataInicio,
            desconto.DataFim,
            desconto.Produtos?.ToList() ?? [],
            desconto.ProdutoId,
            desconto.Ativo
        );
    }

    public async Task<DescontoDto> Atualizar(DescontoDto entity)
    {
        var desconto = await _context.Descontos.FindAsync(entity.Id);
        if (desconto == null)
        {
            return null!;
        }

        desconto.Valor = (double)entity.Valor;
        desconto.DataInicio = entity.DataInicio;
        desconto.DataFim = entity.DataFim;
        desconto.ProdutoId = entity.ProdutoId;
        desconto.Ativo = entity.Ativo;

        _context.Descontos.Update(desconto);
        await _context.SaveChangesAsync();

        return new DescontoDto(
            desconto.Id,
            (decimal)desconto.Valor,
            desconto.DataInicio,
            desconto.DataFim,
            desconto.Produtos?.ToList() ?? [],
            desconto.ProdutoId,
            desconto.Ativo
        );
    }

    public async Task<bool> Deletar(int id)
    {
        var Desconto = await _context.Descontos.FindAsync(id);
        if (Desconto == null)
        {
            return false;
        }
        _context.Descontos.Remove(Desconto);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<DescontoDto> ObterPorId(int id)
    {
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
                [.. desconto.Produtos],
                desconto.ProdutoId,
                desconto.Ativo
            );
    }
    }

    public async Task<List<DescontoDto>> ObterTodos()
    {
        var descontos = await _context.Descontos.ToListAsync();
        return [.. descontos.Select(p => new DescontoDto(
            p.Id,
            (decimal)p.Valor,
            p.DataInicio,
            p.DataFim,
            p.Produtos?.ToList() ?? [],
            p.ProdutoId,
            p.Ativo
        ))];
    }
}