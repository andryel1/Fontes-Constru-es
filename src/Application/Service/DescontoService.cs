using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service
{
    public class DescontoService(IDescontoService descontoService) : IDescontoService
    {
        private readonly IDescontoService _descontoService = descontoService;

        public async Task<DescontoDto> ObterDescontoPorId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("O Id não pode ser menor que 0.");
            }
            return await _descontoService.ObterDescontoPorId(id);
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
