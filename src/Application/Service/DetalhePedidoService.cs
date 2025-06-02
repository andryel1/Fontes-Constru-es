using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service
{
    public class DetalhePedidoService(IDetalhePedidoService detalhePedido) : IDetalhePedidoService
    {
        private readonly IDetalhePedidoService _detalhePedido = detalhePedido;

        public async Task<DescontoDto> ObterDescontoPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id deve ser maior que zero.", nameof(id));

            return await _detalhePedido.ObterDescontoPorId(id);
        }

        public async Task<IEnumerable<DescontoDto>> ObterDescontosAtivos()
        {
            return await _detalhePedido.ObterDescontosAtivos();
        }

        public async Task<IEnumerable<DescontoDto>> ObterDescontosInativos()
        {
            return await _detalhePedido.ObterDescontosInativos();
        }

        public async Task<IEnumerable<DescontoDto>> ObterDescontosExpirados()
        {
            return await _detalhePedido.ObterDescontosExpirados();
        }

        public async Task<DescontoDto> Adicionar(DescontoDto dto)
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto), "O DTO não pode ser nulo.");

            if (string.IsNullOrWhiteSpace(dto.Nome))
                throw new ArgumentException("O nome do desconto é obrigatório.");

            return await _detalhePedido.Adicionar(dto);
        }

        public async Task<DescontoDto> Atualizar(DescontoDto dto)
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto), "O DTO não pode ser nulo.");

            if (dto.ProdutoId <= 0)
                throw new ArgumentException("Id deve ser maior que zero.");

            return await _detalhePedido.Atualizar(dto);
        }

        public async Task<bool> Deletar(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id deve ser maior que zero.");

            return await _detalhePedido.Deletar(id);
        }

        public async Task<DescontoDto> ObterPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id deve ser maior que zero.");

            return await _detalhePedido.ObterPorId(id);
        }

        public async Task<List<DescontoDto>> ObterTodos()
        {
            return await _detalhePedido.ObterTodos();
        }
    }
}