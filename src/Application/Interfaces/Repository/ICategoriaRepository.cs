using Application.Dtos;
using Ecommerce.Domain.Entities;

namespace Application.Interfaces.Repository;

public interface ICategoriaRepository : IInterfaceBaseRepository<CategoriaDto, Categoria>
{
    Task<List<CategoriaDto>> ObterCategoriasPorNome(string nome);
    Task<List<CategoriaDto>> ObterCategoriasPorProdutoId(int produtoId);
    Task<bool> AdicionarProdutoACategoria(int categoriaId, int produtoId);
    Task<bool> RemoverProdutoDaCategoria(int categoriaId, int produtoId);

}