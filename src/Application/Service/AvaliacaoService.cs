using Application.Dtos;
using Application.Interfaces.Service;

namespace Application.Service
{
    public class AvaliacaoService(IAvaliacaoService avaliacaoService) : IAvaliacaoService
    {
        private readonly IAvaliacaoService _avaliacaoService = avaliacaoService;

       public Task<AvaliacaoDto> Adicionar(AvaliacaoDto entity)
        {
            throw new NotImplementedException();
        }
        public Task<AvaliacaoDto> Atualizar(AvaliacaoDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AvaliacaoDto>> ObterAvaliacoesPorProdutoId(int produtoId)
        {
            throw new NotImplementedException();
        }

        public Task<List<AvaliacaoDto>> ObterAvaliacoesPorUsuarioId(int usuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<AvaliacaoDto> ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AvaliacaoDto>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
