using Application.Interfaces.Repository;
using Application.Dtos;

namespace Application.Interfaces.Service
{
    public interface IProdutoService : IProdutoRepository
    {
        Task<ProdutoDto> VerificarProdutoExistente(string nome);
        Task<ProdutoDto> NomeNaoPodeSerVazioOuNUlo(string nome);
        Task<ProdutoDto> DescricaoNaoPodeSerVazioOuNulo(string descricao);
        Task<ProdutoDto> PrecoNaoPodeSerVazioOuNulo(decimal preco);
    }
}
