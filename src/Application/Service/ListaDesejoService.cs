using Application.Dtos;
using Application.Interfaces.Repository;
using Application.Interfaces.Service;

namespace Application.Service;

public class ListaDesejoService : IListaDesejoService
{
    private readonly IListaDesejoRepository _listaDesejoRepository;

    public ListaDesejoService(IListaDesejoRepository listaDesejoService)
    {
        _listaDesejoRepository = listaDesejoService;
    }

    public Task<ListaDesejoDto> ObterListaDesejoPorUsuario(Guid usuarioId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> VerificaSeProdutoJaEstaNaLista(Guid usuarioId, Guid produtoId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AdicionarProdutoNaLista(Guid usuarioId, Guid produtoId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoverProdutoDaLista(Guid usuarioId, Guid produtoId)
    {
        throw new NotImplementedException();
    }

    public Task<ListaDesejoDto> Adicionar(ListaDesejoDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<ListaDesejoDto> Atualizar(ListaDesejoDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Deletar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ListaDesejoDto> ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ListaDesejoDto>> ObterTodos()
    {
        throw new NotImplementedException();
    }
}

    