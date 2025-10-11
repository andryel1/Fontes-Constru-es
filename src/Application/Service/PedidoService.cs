using Application.Interfaces.Service;
using Application.Interfaces.Repository; // Adicionado para a injeção do Repositório
using Application.Dtos;
using Ecommerce.Domain.Entities; // Certifique-se de que este using está correto

namespace Application.Service;

// CORREÇÃO 1: Removida a auto-injeção no construtor primário.
public class PedidoService : IPedidoService
{
    // Variável para o Repositório, que fará o acesso a dados.
    private readonly IPedidoRepository _repository;

    // CORREÇÃO 2: O construtor agora recebe a interface do Repositório.
    // Você DEVE ter registrado IPedidoRepository no seu Program.cs.
    public PedidoService(IPedidoRepository repository)
    {
        _repository = repository;
    }

    // CORREÇÃO 3: Todos os métodos agora chamam o Repositório (_repository) para executar a lógica.

    public async Task<IEnumerable<PedidoDto>> ObterPedidosPorClienteId(Cliente clienteId)
    {
        return await _repository.ObterPedidosPorClienteId(clienteId);
    }

    public async Task<bool> AtualizarStatusPedido(Guid pedidoId, string novoStatus)
    {
        return await _repository.AtualizarStatusPedido(pedidoId, novoStatus);
    }

    public async Task<PedidoDto> Adicionar(PedidoDto dto)
    {
        return await _repository.Adicionar(dto);
    }

    public async Task<PedidoDto> Atualizar(PedidoDto dto)
    {
        return await _repository.Atualizar(dto);
    }

    public async Task<bool> Deletar(int id)
    {
        return await _repository.Deletar(id);
    }

    public async Task<PedidoDto> ObterPorId(int id)
    {
        return await _repository.ObterPorId(id);
    }

    public async Task<List<PedidoDto>> ObterTodos()
    {
        return await _repository.ObterTodos();
    }
}