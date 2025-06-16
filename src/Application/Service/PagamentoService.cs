using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service
{
    public class PagamentoService(IPagamentoService pagamentoService) : IPagamentoService
    {
        private readonly IPagamentoService _pagamentoService = pagamentoService;

        public async Task<PagamentoDto> Adicionar(PagamentoDto dto)
        {
            return await _pagamentoService.Adicionar(dto);
        }

        public async Task<PagamentoDto> Atualizar(PagamentoDto dto)
        {
            return await _pagamentoService.Atualizar(dto);
        }

        public async Task<bool> Deletar(int id)
        {
            return await _pagamentoService.Deletar(id);
        }

        public async Task<PagamentoDto> ObterPorId(int id)
        {
            return await _pagamentoService.ObterPorId(id);
        }

        public async Task<List<PagamentoDto>> ObterTodos()
        {
            return await _pagamentoService.ObterTodos();
        }

        public async Task<PagamentoDto> ObterPagamentoPorPedidoId(int pedidoId)
        {
            return await _pagamentoService.ObterPagamentoPorPedidoId(pedidoId);
        }

        public async Task<bool> VerificarSePagamentoJaFoiRealizado(int pedidoId)
        {
            return await _pagamentoService.VerificarSePagamentoJaFoiRealizado(pedidoId);
        }
        }
    }

