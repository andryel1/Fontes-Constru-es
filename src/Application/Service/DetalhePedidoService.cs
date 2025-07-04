using Application.Dtos;
using Application.Interfaces.Service;

namespace Application.Service
{
    public class DetalhePedidoService(IDetalhePedidoService descontoService) : IDetalhePedidoService
    {
        private readonly IDetalhePedidoService _detalhePedido = descontoService;

        public Task<DetalhePedidoDto> Adicionar(DetalhePedidoDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<DetalhePedidoDto> Atualizar(DetalhePedidoDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DetalhePedidoDto> ObterDetalhePedidoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DetalhePedidoDto>> ObterDetalhesPedidoPorPedidoId(int pedidoId)
        {
            throw new NotImplementedException();
        }

        public Task<DetalhePedidoDto> ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DetalhePedidoDto>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}