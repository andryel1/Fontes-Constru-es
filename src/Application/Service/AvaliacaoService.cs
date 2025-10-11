using Application.Dtos;
using Application.Interfaces.Service;
using Application.Interfaces.Repository; // 🚨 ESSENCIAL: Adicionar este using.

namespace Application.Service
{
    public class AvaliacaoService : IAvaliacaoService
    {
        // Variável de leitura para o Repositório. O nome "_repository" é uma convenção melhor.
        private readonly IAvaliacaoRepository _repository; 

        // 🚨 CORREÇÃO: Construtor para injetar o Repositório, eliminando a circularidade.
        public AvaliacaoService(IAvaliacaoRepository repository)
        {
            _repository = repository;
        }

        // 🚨 CORREÇÃO: Todos os métodos agora chamam a variável correta (_repository).
        public async Task<AvaliacaoDto> Adicionar(AvaliacaoDto entity)
        {
             if (entity.Nota < 1 || entity.Nota > 5)
                throw new ArgumentException("Nota deve ser entre 1 e 5.");
             if (entity == null)
                throw new ArgumentNullException(nameof(entity), "Avaliação não pode ser nula.");
            return await _repository.Adicionar(entity); // Chamada corrigida
        }

        public async Task<AvaliacaoDto> Atualizar(AvaliacaoDto entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity), "Avaliação não pode ser nula.");
            if (entity.Nota < 1 || entity.Nota > 5)
                throw new ArgumentException("Nota deve ser entre 1 e 5.");

            return await _repository.Atualizar(entity); // Chamada corrigida
        }

        public async Task<bool> Deletar(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id inválido para exclusão.");
                

            return await _repository.Deletar(id); // Chamada corrigida
        }

        public async Task<List<AvaliacaoDto>> ObterAvaliacoesPorProdutoId(int produtoId)
        {
            if (produtoId <= 0)
                throw new ArgumentException("Produto inválido.");

            return await _repository.ObterAvaliacoesPorProdutoId(produtoId); // Chamada corrigida
        }

        public async Task<List<AvaliacaoDto>> ObterAvaliacoesPorUsuarioId(int usuarioId)
        {
            if (usuarioId <= 0)
                throw new ArgumentException("UsuarioId inválido.");

            return await _repository.ObterAvaliacoesPorUsuarioId(usuarioId); // Chamada corrigida
        }

        public async Task<AvaliacaoDto> ObterPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id inválido.");

            return await _repository.ObterPorId(id); // Chamada corrigida
        }

        public async Task<List<AvaliacaoDto>> ObterTodos()
        {
            return await _repository.ObterTodos(); // Chamada corrigida
        }
    }
}