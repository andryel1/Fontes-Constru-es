using Application.Dtos;
using Ecommerce.Domain.Entities;

namespace Application.Interfaces.Repository;
public interface IAvaliaçaoRepository : IInterfaceBaseRepository<AvaliacaoDto, Avaliacao>
{
    Task<List<AvaliacaoDto>> ObterAvaliacoesPorProdutoId(int produtoId);
    Task<List<AvaliacaoDto>> ObterAvaliacoesPorUsuarioId(int usuarioId);
}