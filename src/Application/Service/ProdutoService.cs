using Application.Dtos;
using Application.Interfaces.Service;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Application.Service;

public class ProdutoService(IProdutoService produto) : IProdutoService
{
    private readonly IProdutoService _produto = produto;

    public async Task<ProdutoDto> VerificarProdutoExistente(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrEmpty(nome))
        {
            throw new ArgumentException("O nome do produto não existe");
        }
        
        return await _produto.VerificarProdutoExistente(nome);
    }

    public async Task<ProdutoDto> NomeNaoPodeSerVazioOuNUlo(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrEmpty(nome))
        {
            throw new ArgumentException("O nome do produto não pode ser vazio ou nulo.");
        }
        return await _produto.NomeNaoPodeSerVazioOuNUlo(nome);
    }

    public async Task<ProdutoDto> DescricaoNaoPodeSerVazioOuNulo(string descricao)
    {
        if (string.IsNullOrWhiteSpace(descricao) || string.IsNullOrEmpty(descricao))
        {
            throw new ArgumentException("A descrição do produto não pode ser vazia ou nula.");
        }
        return await _produto.DescricaoNaoPodeSerVazioOuNulo(descricao);
    }

    public async Task<ProdutoDto> PrecoNaoPodeSerVazioOuNulo(decimal preco)
    {
        if (preco <= 0)
        {
            throw new ArgumentException("O preço do produto não pode ser menor ou igual a zero.");
        }
        return await _produto.PrecoNaoPodeSerVazioOuNulo(preco);
    }

    public Task<List<ProdutoDto>> ObterProdutosPorCategoria(string categoria)
    {
        if (string.IsNullOrWhiteSpace(categoria) || string.IsNullOrEmpty(categoria))
        {
            throw new ArgumentException("A categoria do produto não pode ser vazia ou nula.");
        }
        return _produto.ObterProdutosPorCategoria(categoria);
    }

    public async Task<List<ProdutoDto>> ObterProdutosPorNome(string nome)
    {
        if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O nome do produto não pode ser vazio ou nulo.");
        }
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
    

    public async Task<ProdutoDto> Atualizar(ProdutoDto dto)
    {
        await VerificarProdutoExistente(dto.Nome);
        await NomeNaoPodeSerVazioOuNUlo(dto.Nome);

        return await _produto.Atualizar(dto);
    }

    public async Task<bool> Deletar(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("O Id Não pode ser menor que 0.");
        }
        return await _produto.Deletar(id);
    }

    public async Task<ProdutoDto> ObterPorId(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("O Id não pode ser menor que 0.");
        }
        return await _produto.ObterPorId(id);
    }

    public async Task<List<ProdutoDto>> ObterTodos()
    {
        return await _produto.ObterTodos();
    }
}