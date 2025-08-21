using Application.Dtos;
using Application.Interfaces.Service;
using Application.Interfaces.Repository;
using AutoMapper;
using Ecommerce.Domain.Entities;

namespace Application.Service;

public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _produtoRepository;
    private readonly IMapper _mapper;

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
        throw new NotImplementedException();
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