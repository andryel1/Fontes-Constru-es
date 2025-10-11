using Application.Interfaces.Service;
using Application.Interfaces.Repository; // Adicionado para a injeção do Repositório
using Application.Dtos;

namespace Application.Service
{
    // A classe PagamentoService agora só implementa a interface, sem a injeção automática errada (pagamentoService).
    public class PagamentoService : IPagamentoService
    {
        // Variável de leitura agora deve ser do Repositório.
        private readonly IPagamentoRepository _repository;

        // CORREÇÃO: O construtor deve injetar o Repositório, não a própria Interface de Serviço.
        // Você deve registrar IPagamentoRepository no Program.cs.
        public PagamentoService(IPagamentoRepository repository)
        {
            _repository = repository;
        }

        // CORREÇÃO: Todos os métodos agora chamam o Repositório (_repository) para executar a lógica.
        public async Task<PagamentoDto> Adicionar(PagamentoDto dto)
        {
            return await _repository.Adicionar(dto);
        }

        public async Task<PagamentoDto> Atualizar(PagamentoDto dto)
        {
            return await _repository.Atualizar(dto);
        }

        public async Task<bool> Deletar(int id)
        {
            return await _repository.Deletar(id);
        }

        public async Task<PagamentoDto> ObterPorId(int id)
        {
            return await _repository.ObterPorId(id);
        }

        public async Task<List<PagamentoDto>> ObterTodos()
        {
            return await _repository.ObterTodos();
        }

        public async Task<PagamentoDto> ObterPagamentoPorPedidoId(int pedidoId)
        {
            return await _repository.ObterPagamentoPorPedidoId(pedidoId);
        }

        public async Task<bool> VerificarSePagamentoJaFoiRealizado(int pedidoId)
        {
            return await _repository.VerificarSePagamentoJaFoiRealizado(pedidoId);
        }
    }
}