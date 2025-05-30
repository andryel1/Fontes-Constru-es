using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service
{
    public class DetalhePedidoService(IDetalhePedidoService detalhePedido) : IDetalhePedidoService
    {
        private readonly IDetalhePedidoService _detalhePedido = detalhePedido;

        public Task<DescontoDto> ObterDescontoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DescontoDto>> ObterDescontosPorProdutoId(int produtoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DescontoDto>> ObterDescontosAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DescontoDto>> ObterDescontosInativos()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DescontoDto>> ObterDescontosExpirados()
        {
            throw new NotImplementedException();
        }

        public Task<DescontoDto> Adicionar(DescontoDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<DescontoDto> Atualizar(DescontoDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DescontoDto> ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DescontoDto>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}