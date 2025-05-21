using Application.Dtos;
using Ecommerce.Domain.Entities;

namespace Application.Interfaces.Repository;

public interface IImagemRepository : IInterfaceBaseRepository<ImagemDto, Imagem>
{
    Task<ImagemDto> ObterImagemPorId(Guid id);
    Task<ImagemDto> ObterImagemPorIdProduto(Guid idProduto);
    Task<IEnumerable<ImagemDto>> ObterImagensPorIdProduto(Guid idProduto);
}