using Application.Dtos;
using Application.Interfaces.Repository;
using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class AvaliacaoRepository(Context context): IAvaliaçaoRepository
{
    private readonly Context _context = context;
 
    public async Task<AvaliacaoDto> Adicionar(AvaliacaoDto entity)
    {
        var Avaliacao = new Avaliacao
        {
            Nota = entity.Nota
        };

        _context.Add(Avaliacao);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<AvaliacaoDto> Atualizar(AvaliacaoDto entity)
    {
        var Avaliacao = await _context.Avaliacoes.FindAsync(entity.Nota);
        if (Avaliacao == null)
            return null!;

        Avaliacao.Nota = entity.Nota;

        _context.Update(Avaliacao);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> Deletar(int id)
    {
        var Avaliacao = await _context.Avaliacoes.FindAsync(id);
        if (Avaliacao == null) return false;

        _context.Avaliacoes.Remove(Avaliacao);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<AvaliacaoDto>> ObterAvaliacoesPorProdutoId()
    {
        var Avaliacao = await _context.Avaliacoes.ToListAsync();
        return [.. Avaliacao.Select(p => new AvaliacaoDto(
            p.Id,
            p.Nota,
            p.Comentario ?? string.Empty,
            p.Data,
            p.ProdutoId


        ))];
    }

    public async Task<List<AvaliacaoDto>> ObterAvaliacoesPorProdutoId(int produtoId)
    {
        var avaliacao = await _context.Avaliacoes.Where(p => p.ProdutoId == produtoId).ToListAsync();
        return [.. avaliacao.Select(p => new AvaliacaoDto(
            p.Id,
            p.Nota,
            p.Comentario ?? string.Empty,
            p.Data,
            p.ProdutoId
        ))];
    }

    public async Task<List<AvaliacaoDto>> ObterAvaliacoesPorUsuarioId(int usuarioId)
    {
        var avaliacoes = await _context.Avaliacoes
            .Where(p => p.ClienteId == usuarioId)
            .ToListAsync();
        return [.. avaliacoes.Select(p => new AvaliacaoDto(
            p.Id,
            p.Nota,
            p.Comentario ?? string.Empty,
            p.Data,
            p.ProdutoId
        ))];
    }

    public async Task<AvaliacaoDto> ObterPorId(int id)
    {
        var avaliacao = await _context.Avaliacoes.FindAsync(id);
        if (avaliacao == null) return null!;

        return new AvaliacaoDto(
            avaliacao.Id,
            avaliacao.Nota,
            avaliacao.Comentario ?? string.Empty,
            avaliacao.Data,
            avaliacao.ProdutoId
        );
    }

    public async Task<List<AvaliacaoDto>> ObterTodos()
    {
        var Avaliacao = await _context.Avaliacoes.ToListAsync();
        return [.. Avaliacao.Select(p => new AvaliacaoDto(
            p.Id,
            p.Nota,
            p.Comentario ?? string.Empty,
            p.Data,
            p.ProdutoId
        ))];
    }
}