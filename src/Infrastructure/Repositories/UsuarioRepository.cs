using Application.Dtos;
using Application.Interfaces.Repository;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Repositories;

public class UsuarioRepository(Context context) : IUsuarioRepository
{
    private readonly Context _context = context;
    public async Task<UsuarioDto> Adicionar(UsuarioDto entity)
    {
        var usuario = new Usuario
        {
            Email = entity.Email,
            
        };
        _context.Add(usuario);
        await _context.SaveChangesAsync();
        return entity;
    }

    public Task<UsuarioDto> Atualizar(UsuarioDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Deletar(int id)
    {
        throw new NotImplementedException();
    }
    public Task<UsuarioDto> ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<UsuarioDto>> ObterTodos()
    {
        throw new NotImplementedException();
    }
}