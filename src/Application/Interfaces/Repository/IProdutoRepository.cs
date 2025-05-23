using Ecommerce.Domain.Entities;
using Application.Dtos;

namespace Application.Interfaces.Repository
{
    public interface IProdutoRepository : IInterfaceBaseRepository<ProdutoDto, Produto>
    {
        Task<List<ProdutoDto>> ObterProdutosPorCategoria(string categoria);
        Task<List<ProdutoDto>> ObterProdutosPorNome(string nome);
    }
}

