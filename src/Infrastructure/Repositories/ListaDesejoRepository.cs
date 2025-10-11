using Application.Dtos;
using Application.Interfaces.Repository;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Repositories;

public class ListaDesejoRepository(Context context) : IListaDesejoRepository
{
    private readonly Context _context = context;
    public async Task<ListaDesejoDto> Adicionar(ListaDesejoDto entity)
    {
        var listaDesejo = new ListaDesejo
        {
            ClienteId = entity.ClienteId
        };
        _context.Add(listaDesejo);
        await _context.SaveChangesAsync();
        return entity;
    }

    public Task<ListaDesejoDto> Atualizar(ListaDesejoDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Deletar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ListaDesejoDto> ObterListaDesejoPorUsuario(Guid usuarioId)
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

    public Task<bool> VerificaSeProdutoJaEstaNaLista(Guid usuarioId, Guid produtoId)
    {
        throw new NotImplementedException();
    }
}