using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service
{
    public class DescontoService : IDescontoService
    {
        private readonly IDescontoService _descontoService;

        public DescontoService(IDescontoService descontoService)
        {
            _descontoService = descontoService;
        }

        public async Task<DescontoDto> ObterDescontoPorId(int id)
        {
            return await _descontoService.ObterDescontoPorId(id);
        }

        public async Task<IEnumerable<DescontoDto>> ObterDescontosPorProdutoId(int produtoId)
        {
            return await _descontoService.ObterDescontosPorProdutoId(produtoId);
        }

        public async Task<IEnumerable<DescontoDto>> ObterDescontosAtivos()
        {
            return await _descontoService.ObterDescontosAtivos();
        }

        public async Task<IEnumerable<DescontoDto>> ObterDescontosInativos()
        {
            return await _descontoService.ObterDescontosInativos();
        }

        public async Task<IEnumerable<DescontoDto>> ObterDescontosExpirados()
        {
            return await _descontoService.ObterDescontosExpirados();
        }

        public async Task<DescontoDto> Adicionar(DescontoDto dto)
        {
            return await _descontoService.Adicionar(dto);
        }

        public async Task<DescontoDto> Atualizar(DescontoDto dto)
        {
            return await _descontoService.Atualizar(dto);
        }

        public async Task<bool> Deletar(int id)
        {
            return await _descontoService.Deletar(id);
        }

        public async Task<DescontoDto> ObterPorId(int id)
        {
            return await _descontoService.ObterPorId(id);
        }

        public async Task<List<DescontoDto>> ObterTodos()
        {
            return await _descontoService.ObterTodos();
        }
    }
}
