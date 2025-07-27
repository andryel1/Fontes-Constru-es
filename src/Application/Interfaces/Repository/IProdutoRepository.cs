using Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IProdutoRepository
{
    Task<ProdutoDto> VerificarProdutoExistente(string nome);
    Task<ProdutoDto> NomeNaoPodeSerVazioOuNUlo(string nome);
    Task<ProdutoDto> DescricaoNaoPodeSerVazioOuNulo(string descricao);
    Task<ProdutoDto> PrecoNaoPodeSerVazioOuNulo(decimal preco);
    Task<List<ProdutoDto>> ObterProdutosPorCategoria(string categoria);
    Task<List<ProdutoDto>> ObterProdutosPorNome(string nome);
    Task<ProdutoDto> Adicionar(ProdutoDto dto);
    Task<ProdutoDto> Atualizar(ProdutoDto dto);
    Task<bool> Deletar(int id);
    Task<ProdutoDto> ObterPorId(int id);
    Task<List<ProdutoDto>> ObterTodos();
}