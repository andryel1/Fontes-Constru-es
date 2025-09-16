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

    public Task<bool> Deletar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<AvaliacaoDto>> ObterAvaliacoesPorProdutoId(int produtoId)
    {
        var Avaliacao = await _context.Avaliacoes.ToListAsync();
        return Avaliacao.Select(p => new AvaliacaoDto(
            p.Id,
            p.Nota,
            p.Comentario ?? string.Empty,
            p.Data,
            p.ProdutoId


        )).ToList();
    }

    public Task<List<AvaliacaoDto>> ObterAvaliacoesPorUsuarioId(int usuarioId)
    {
        throw new NotImplementedException();
    }

    public Task<AvaliacaoDto> ObterPorId(int id)
    {
        throw new NotImplementedException();
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