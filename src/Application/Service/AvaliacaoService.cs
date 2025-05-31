using Application.Dtos;
using Application.Interfaces.Service;

namespace Application.Service
{
    public class AvaliacaoService(IAvaliacaoService avaliacaoService) : IAvaliacaoService
    {
        private readonly IAvaliacaoService _avaliacaoService = avaliacaoService;

        public async Task<AvaliacaoDto> Adicionar(AvaliacaoDto entity)
        {
             if (entity.Nota < 1 || entity.Nota > 5)
                throw new ArgumentException("Nota deve ser entre 1 e 5.");
             if (entity == null)
                throw new ArgumentNullException(nameof(entity), "Avaliação não pode ser nula.");
            return await _avaliacaoService.Adicionar(entity);
        }

        public async Task<AvaliacaoDto> Atualizar(AvaliacaoDto entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity), "Avaliação não pode ser nula.");
            if (entity.Nota < 1 || entity.Nota > 5)
                throw new ArgumentException("Nota deve ser entre 1 e 5.");

            return await _avaliacaoService.Atualizar(entity);
        }

        public async Task<bool> Deletar(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id inválido para exclusão.");
                

            return await _avaliacaoService.Deletar(id);
        }

        public async Task<List<AvaliacaoDto>> ObterAvaliacoesPorProdutoId(int produtoId)
        {
            if (produtoId <= 0)
                throw new ArgumentException("Produto inválido.");

            return await _avaliacaoService.ObterAvaliacoesPorProdutoId(produtoId);
        }

        public async Task<List<AvaliacaoDto>> ObterAvaliacoesPorUsuarioId(int usuarioId)
        {
            if (usuarioId <= 0)
                throw new ArgumentException("UsuarioId inválido.");

            return await _avaliacaoService.ObterAvaliacoesPorUsuarioId(usuarioId);
        }

        public async Task<AvaliacaoDto> ObterPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id inválido.");

            return await _avaliacaoService.ObterPorId(id);
        }

        public async Task<List<AvaliacaoDto>> ObterTodos()
        {
            return await _avaliacaoService.ObterTodos();
        }

    }
}
