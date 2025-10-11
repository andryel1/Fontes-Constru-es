using Application.Interfaces.Service;
using Application.Interfaces.Repository; // Adicionar este using
using Application.Dtos;

namespace Application.Service;

// A classe agora implementa a interface, mas não injeta a si mesma.
public class InformacoesEnvioService : IInformacoesEnvioService
{
    // Variável para o Repositório, que fará o acesso a dados.
    private readonly IInformacoesEnvioRepository _repository;

    // CORREÇÃO: O construtor recebe o Repositório, eliminando a circularidade.
    public InformacoesEnvioService(IInformacoesEnvioRepository repository)
    {
        _repository = repository;
    }

    // CORREÇÃO: Todos os métodos agora chamam o Repositório (_repository).

    public async Task<InformacoesEnvioDto> Adicionar(InformacoesEnvioDto dto)
    {
        // Adicionar validações aqui, se necessário.
        return await _repository.Adicionar(dto);
    }

    public async Task<InformacoesEnvioDto> Atualizar(InformacoesEnvioDto dto)
    {
        return await _repository.Atualizar(dto);
    }

    public async Task<bool> Deletar(int id)
    {
        return await _repository.Deletar(id);
    }

    public async Task<InformacoesEnvioDto> ObterPorId(int id)
    {
        return await _repository.ObterPorId(id);
    }

    public async Task<List<InformacoesEnvioDto>> ObterTodos()
    {
        return await _repository.ObterTodos();
    }
}