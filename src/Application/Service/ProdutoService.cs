using Application.Dtos;
using Application.Interfaces.Service;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Application.Service;

public class ProdutoService(IProdutoService produto) : IProdutoService
{
    private readonly IProdutoService _produto = produto;

    public async Task<ProdutoDto> VerificarProdutoExistente(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O nome do produto não existe");
        }
        
        return await _produto.VerificarProdutoExistente(nome);
    }

    public async Task<ProdutoDto> NomeNaoPodeSerVazioOuNUlo(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O nome do produto não pode ser vazio ou nulo.");
        }
        return await _produto.NomeNaoPodeSerVazioOuNUlo(nome);
    }

    public Task<ProdutoDto> DescricaoNaoPodeSerVazioOuNulo(string descricao)
    {
        return _produto.DescricaoNaoPodeSerVazioOuNulo(descricao);
    }

    public async Task<ProdutoDto> PrecoNaoPodeSerVazioOuNulo(decimal preco)
    {
        if (preco <= 0)
        {
            throw new ArgumentException("O preço do produto não pode ser vazio, nulo ou menor ou igual a zero.");
        }
        return await _produto.PrecoNaoPodeSerVazioOuNulo(preco);
    }

    public Task<List<ProdutoDto>> ObterProdutosPorCategoria(string categoria)
    {
        return _produto.ObterProdutosPorCategoria(categoria);
    }

    public async Task<List<ProdutoDto>> ObterProdutosPorNome(string nome)
    {

        return await _produto.ObterProdutosPorNome(nome);
    }
    public async Task<ProdutoDto> Adicionar(ProdutoDto dto)
    {
        await NomeNaoPodeSerVazioOuNUlo(dto.Nome);
        await VerificarProdutoExistente(dto.Nome);
        await DescricaoNaoPodeSerVazioOuNulo(dto.Descricao);
        await PrecoNaoPodeSerVazioOuNulo(dto.Preco);

        return await _produto.Adicionar(dto);
    }
    

    public Task<ProdutoDto> Atualizar(ProdutoDto dto)
    {
        return _produto.Atualizar(dto);
    }

    public async Task<bool> Deletar(int id)
    {

        return await _produto.Deletar(id);
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