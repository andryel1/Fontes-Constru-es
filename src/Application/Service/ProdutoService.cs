using Application.Dtos;
using Application.Interfaces.Service;

namespace Application.Service;

public class ProdutoService(IProdutoService produto) : IProdutoService
{
    private readonly IProdutoService _produto = produto;

    public Task<ProdutoDto> VerificarProdutoExistente(string nome)
    {
        return _produto.VerificarProdutoExistente(nome);
    }

    public Task<ProdutoDto> NomeNaoPodeSerVazioOuNUlo(string nome)
    {
        return _produto.NomeNaoPodeSerVazioOuNUlo(nome);
    }

    public Task<ProdutoDto> DescricaoNaoPodeSerVazioOuNulo(string descricao)
    {
        return _produto.DescricaoNaoPodeSerVazioOuNulo(descricao);
    }

    public Task<ProdutoDto> PrecoNaoPodeSerVazioOuNulo(decimal preco)
    {
        return _produto.PrecoNaoPodeSerVazioOuNulo(preco);
    }

    public Task<List<ProdutoDto>> ObterProdutosPorCategoria(string categoria)
    {
        return _produto.ObterProdutosPorCategoria(categoria);
    }

    public Task<List<ProdutoDto>> ObterProdutosPorNome(string nome)
    {
        return _produto.ObterProdutosPorNome(nome);
    }

    public Task<ProdutoDto> Adicionar(ProdutoDto dto)
    {
        return _produto.Adicionar(dto);
    }

    public Task<ProdutoDto> Atualizar(ProdutoDto dto)
    {
        return _produto.Atualizar(dto);
    }

    public Task<bool> Deletar(int id)
    {
        return _produto.Deletar(id);
    }

    public Task<ProdutoDto> ObterPorId(int id)
    {
        return _produto.ObterPorId(id);
    }

    public Task<List<ProdutoDto>> ObterTodos()
    {
        return _produto.ObterTodos();
    }
}