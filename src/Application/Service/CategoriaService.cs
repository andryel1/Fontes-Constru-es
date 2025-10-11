using Application.Interfaces.Service;
using Application.Interfaces.Repository; // Adicionar este using
using Application.Dtos;

namespace Application.Service
{
    // A classe agora implementa a interface, mas não injeta a si mesma no construtor.
    public class CategoriaService : ICategoriaService
    {
        // Variável de leitura para o Repositório, que fará o acesso a dados.
        private readonly ICategoriaRepository _repository;

        // CORREÇÃO: O construtor agora recebe a interface do Repositório.
        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        // CORREÇÃO: Todos os métodos agora chamam o Repositório (_repository).

        public Task<List<CategoriaDto>> ObterCategoriasPorNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("O nome não pode ser vazio o nulo.");
            }
            return _repository.ObterCategoriasPorNome(nome);
        }

        public Task<List<CategoriaDto>> ObterCategoriasPorProdutoId(int produtoId)
        {
            if (produtoId <= 0)
            {
                throw new ArgumentException("Não pode ser menor ou igual 0.");
            }
            return _repository.ObterCategoriasPorProdutoId(produtoId);
        }

        public async Task<bool> AdicionarProdutoACategoria(int categoriaId, int produtoId)
        {
            if (categoriaId <= 0)
            {
            throw new ArgumentException("O categoriaId deve ser um número positivo.");
            }
            if (produtoId <= 0)
            {
            throw new ArgumentException("O produtoId deve ser um número positivo.");
            }
            return await _repository.AdicionarProdutoACategoria(categoriaId, produtoId);
        }

        public async Task<bool> RemoverProdutoDaCategoria(int categoriaId, int produtoId)
        {
            if (categoriaId <= 0)
            {
                throw new ArgumentException($"O categoriaId {categoriaId} não pode ser menor ou igual a zero");
            }
            return await _repository.RemoverProdutoDaCategoria(categoriaId, produtoId);
        }
        public async Task<CategoriaDto> Adicionar(CategoriaDto dto)
        {
            if (string.IsNullOrEmpty(dto.Nome))
            {
                throw new ArgumentException("Nome não pode ser nulo e nem vazio.");
            }
            if (dto.Produtos == null)
            {
                throw new ArgumentException("Produto é obrigatório para fazer isso.");
            }
            return await _repository.Adicionar(dto);
        }

        public async Task<CategoriaDto> Atualizar(CategoriaDto dto)
        {
            if (dto == null)
            {
            throw new ArgumentNullException(nameof(dto), "O objeto CategoriaDto não pode ser nulo.");
            }
            if (string.IsNullOrWhiteSpace(dto.Nome))
            {
            throw new ArgumentException("Nome não pode ser nulo, vazio ou composto apenas por espaços em branco.");
            }
            return await _repository.Atualizar(dto);
        }

        public async Task<bool> Deletar(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("O id deve ser um número positivo.");
            }
            return await _repository.Deletar(id);
        }

        public async Task<CategoriaDto> ObterPorId(int id)
        {
            if (id <= 0)
            {
                  throw new ArgumentException("Id não encontrado. O id deve ser um número positivo.");
            }
            return await _repository.ObterPorId(id);
        }

        public async Task<List<CategoriaDto>> ObterTodos()
        {
            return await _repository.ObterTodos();
        }
    }
}