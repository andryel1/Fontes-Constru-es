using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service;

// Implements all required interfaces
public class TagService(ITagService tagService) : ITagService
{
    private readonly ITagService _tagService = tagService;

    public async Task<TagDto> Adicionar(TagDto dto)
    {
        return await _tagService.Adicionar(dto);
    }

    public async Task<TagDto> Atualizar(TagDto dto)
    {
        return await _tagService.Atualizar(dto);
    }

    public async Task<bool> Deletar(int id)
    {
        return await _tagService.Deletar(id);
    }

    public async Task<TagDto> ObterPorId(int id)
    {
        return await _tagService.ObterPorId(id);
    }

    public async Task<List<TagDto>> ObterTodos()
    {
        return await _tagService.ObterTodos();
    }

    public async Task<TagDto> GetTagById(int id)
    {
        return await _tagService.GetTagById(id);
    }

    public async Task<List<TagDto>> GetTagsByProdutoId(int produtoId)
    {
        return await _tagService.GetTagsByProdutoId(produtoId);
    }

    public async Task<List<TagDto>> GetTagsByCategoriaId(int categoriaId)
    {
        return await _tagService.GetTagsByCategoriaId(categoriaId);
    }
}
