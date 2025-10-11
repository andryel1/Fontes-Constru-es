using Application.Dtos;
using Application.Interfaces.Service;
using Application.Interfaces.Repository;
using AutoMapper;
using Ecommerce.Domain.Entities;

namespace Application.Service;

public class ProdutoService(IProdutoRepository produtoRepository) : IProdutoService
{
    private readonly IProdutoRepository _produtoRepository = produtoRepository;

    public Task<ProdutoDto> VerificarProdutoExistente(string nome)
    {
        throw new NotImplementedException();
    }

    public Task<ProdutoDto> NomeNaoPodeSerVazioOuNUlo(string nome)
    {
        throw new NotImplementedException();
    }

    public Task<ProdutoDto> DescricaoNaoPodeSerVazioOuNulo(string descricao)
    {
        throw new NotImplementedException();
    }

    public Task<ProdutoDto> PrecoNaoPodeSerVazioOuNulo(decimal preco)
    {
        throw new NotImplementedException();
    }

    public Task<ProdutoDto> Adicionar(ProdutoDto dto)
    {
        return _produtoRepository.Adicionar(dto);
    }

    public Task<ProdutoDto> Atualizar(ProdutoDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Deletar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ProdutoDto> ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ProdutoDto>> ObterTodos()
    {
        throw new NotImplementedException();
    }
}