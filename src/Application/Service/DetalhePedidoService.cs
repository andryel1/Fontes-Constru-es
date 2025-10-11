using Application.Dtos;
using Application.Interfaces.Service;
using Application.Interfaces.Repository; // Adicionado para a injeção do Repositório

namespace Application.Service
{
    // A classe agora implementa a interface, mas não injeta a si mesma.
    public class DetalhePedidoService : IDetalhePedidoService
    {
        // Variável de leitura para o Repositório, que fará o acesso a dados.
        private readonly IDetalhePedidoRepository _repository;

        // CORREÇÃO: O construtor agora recebe a interface do Repositório, eliminando a circularidade.
        public DetalhePedidoService(IDetalhePedidoRepository repository)
        {
            _repository = repository;
        }

        // CORREÇÃO: Todos os métodos agora chamam o Repositório (_repository) ou usam lógica de negócio.

        public Task<DetalhePedidoDto> Adicionar(DetalhePedidoDto entity)
        {
            return _repository.Adicionar(entity);
        }

        public Task<DetalhePedidoDto> Atualizar(DetalhePedidoDto entity)
        {
            return _repository.Atualizar(entity);
        }

        public Task<bool> Deletar(int id)
        {
            return _repository.Deletar(id);
        }

        public Task<DetalhePedidoDto> ObterDetalhePedidoPorId(int id)
        {
            return _repository.ObterDetalhePedidoPorId(id);
        }

        public Task<IEnumerable<DetalhePedidoDto>> ObterDetalhesPedidoPorPedidoId(int pedidoId)
        {
            return _repository.ObterDetalhesPedidoPorPedidoId(pedidoId);
        }

        public Task<DetalhePedidoDto> ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public Task<List<DetalhePedidoDto>> ObterTodos()
        {
            return _repository.ObterTodos();
        }
    }
}