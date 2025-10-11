using Application.Interfaces.Service;
using Application.Interfaces.Repository; // Adicionado para a injeção do Repositório
using Application.Dtos;
using System.Threading.Tasks;

namespace Application.Service;

public class ClienteService : IClienteService
{
    // Variável de leitura para o Repositório, que fará o acesso a dados.
    private readonly IClienteRepository _repository;

    // CORREÇÃO: O construtor agora recebe a interface do Repositório, eliminando a circularidade.
    public ClienteService(IClienteRepository repository)
    {
        _repository = repository;
    }

    // CORREÇÃO: Todos os métodos agora chamam o Repositório (_repository).

    public async Task<ClienteDto> Adicionar(ClienteDto dto)
    {
        return await _repository.Adicionar(dto);
    }

    public async Task<ClienteDto> Atualizar(ClienteDto dto)
    {
        return await _repository.Atualizar(dto);
    }

    public async Task<bool> Deletar(int id)
    {
        return await _repository.Deletar(id);
    }

    public async Task<ClienteDto> ObterPorId(int id)
    {
        return await _repository.ObterPorId(id);
    }

    public async Task<List<ClienteDto>> ObterTodos()
    {
        return await _repository.ObterTodos();
    }
}