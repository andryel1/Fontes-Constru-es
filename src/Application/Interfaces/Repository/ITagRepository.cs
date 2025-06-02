using Application.Dtos;
using Ecommerce.Domain.Entities;

namespace Application.Interfaces.Repository;

public interface ITagRepository : IInterfaceBaseRepository<TagDto, Tag>
{
}