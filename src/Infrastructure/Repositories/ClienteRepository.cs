using Application.Dtos;
using Application.Interfaces.Repository;

using Ecommerce.Domain.Entities;

namespace Infrastructure.Repositories;

public class ClienteRepository(Context context) : IClienteRepository
{
    private readonly Context _context = context;

    public async Task<ClienteDto> Adicionar(ClienteDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ClienteDto> Atualizar(ClienteDto entity)
    {
     throw new NotImplementedException();
    }

    public async Task<bool> Deletar(int id)
    {
        var cliente = await _context.Clientes.FindAsync(id);
        if (cliente == null) return false;

        _context.Clientes.Remove(cliente);
        await _context.SaveChangesAsync();
        return true;
    }

  

    Task<ClienteDto> IInterfaceBaseRepository<ClienteDto, Cliente>.ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    Task<List<ClienteDto>> IInterfaceBaseRepository<ClienteDto, Cliente>.ObterTodos()
    {
        throw new NotImplementedException();
    }
}