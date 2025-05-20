using Ecommerce.Domain.Entities;
using Application.Dtos;

namespace Application.Repository
{
    public interface IProdutoService
    {
        Task<ProdutoDto> AdicionarProduto(ProdutoDto produto);
        Task<ProdutoDto> AtualizarProduto(ProdutoDto produto);
        Task<bool> DeletarProduto(int id);
        Task<ProdutoDto> ObterProdutoPorId(int id);
        Task<List<ProdutoDto>> ObterTodosProdutos();
        Task<List<ProdutoDto>> ObterProdutosPorCategoria(string categoria);
        Task<List<ProdutoDto>> ObterProdutosPorNome(string nome);
    }
}

