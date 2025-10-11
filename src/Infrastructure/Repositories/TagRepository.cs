using Application.Dtos;
using Application.Interfaces.Repository;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Repositories;

public class TagRepository(Context context) : ITagRepository
{
    private readonly Context _context = context;
    public async Task<TagDto> Adicionar(TagDto entity)
    {
        var tag = new Tag
        {
            Nome = entity.Nome,
            
        };
        _context.Add(tag);
        await _context.SaveChangesAsync();
        return entity;
    }

    public Task<TagDto> Atualizar(TagDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Deletar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<TagDto> ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<TagDto>> ObterTodos()
    {
        throw new NotImplementedException();
    }
}