using Application.Dtos;
using Ecommerce.Domain.Entities;

namespace Application.Interfaces.Repository;

public interface ITagRepository : IInterfaceBaseRepository<TagDto, Tag>
{
    Task<TagDto> GetTagById(int id);
    Task<List<TagDto>> GetTagsByProdutoId(int produtoId);
    Task<List<TagDto>> GetTagsByCategoriaId(int categoriaId);
}