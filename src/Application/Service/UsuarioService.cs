using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service;

public class UsuarioService(IUsuarioService usuarioService) : IUsuarioService
{
    private readonly IUsuarioService _usuarioService = usuarioService;

    public async Task<UsuarioDto> Adicionar(UsuarioDto dto)
    {
        return await _usuarioService.Adicionar(dto);
    }

    public async Task<UsuarioDto> Atualizar(UsuarioDto dto)
    {
        return await _usuarioService.Atualizar(dto);
    }

    public async Task<bool> Deletar(int id)
    {
        return await _usuarioService.Deletar(id);
    }

    public async Task<UsuarioDto> ObterPorId(int id)
    {
        return await _usuarioService.ObterPorId(id);
    }

    public async Task<List<UsuarioDto>> ObterTodos()
    {
        return await _usuarioService.ObterTodos();
    }
}
