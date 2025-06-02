using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service;

// Implements all required interfaces
public class TagService(ITagService tagService) : ITagService
{
    private readonly ITagService _tagService = tagService;

    public async Task<TagDto> Adicionar(TagDto dto)
    {
        if (string.IsNullOrEmpty(dto.Nome))
        {
            throw new ArgumentException("O nome não pode ser ");
        }
        if (dto.Produtos == null)
        {
            throw new ArgumentException("Produto é obrigatório.");
        }
        return await _tagService.Adicionar(dto);
    }

    public async Task<TagDto> Atualizar(TagDto dto)
    {
        if (string.IsNullOrEmpty(dto.Nome))
        {
            throw new ArgumentException("Nome é obrigatório");
        }
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
}
