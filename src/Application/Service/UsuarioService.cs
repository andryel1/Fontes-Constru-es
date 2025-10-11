using Application.Interfaces.Service;
using Application.Interfaces.Repository; // Adicionado para a injeção do Repositório
using Application.Dtos;

namespace Application.Service;

public class UsuarioService : IUsuarioService
{
    // Variável de leitura para o Repositório, que fará o acesso a dados.
    private readonly IUsuarioRepository _repository;

    // CORREÇÃO: O construtor agora recebe a interface do Repositório, eliminando a circularidade.
    public UsuarioService(IUsuarioRepository repository)
    {
        _repository = repository;
    }

    // CORREÇÃO: Todos os métodos agora chamam o Repositório (_repository).

    public async Task<UsuarioDto> Adicionar(UsuarioDto dto)
    {
        return await _repository.Adicionar(dto);
    }

    public async Task<UsuarioDto> Atualizar(UsuarioDto dto)
    {
        return await _repository.Atualizar(dto);
    }

    public async Task<bool> Deletar(int id)
    {
        return await _repository.Deletar(id);
    }

    public async Task<UsuarioDto> ObterPorId(int id)
    {
        return await _repository.ObterPorId(id);
    }

    public async Task<List<UsuarioDto>> ObterTodos()
    {
        return await _repository.ObterTodos();
    }
}