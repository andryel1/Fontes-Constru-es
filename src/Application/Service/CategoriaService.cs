using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service
{
    public class CategoriaService(ICategoriaService categoriaService) : ICategoriaService
    {
        private readonly ICategoriaService _categoriaService = categoriaService;

        public Task<List<CategoriaDto>> ObterCategoriasPorNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("O nome não pode ser vazio o nulo.");
            }
            return _categoriaService.ObterCategoriasPorNome(nome);
        }

        public Task<List<CategoriaDto>> ObterCategoriasPorProdutoId(int produtoId)
        {
            if (produtoId <= 0)
            {
                throw new ArgumentException("Não pode ser menor ou igual 0.");
            }
            return _categoriaService.ObterCategoriasPorProdutoId(produtoId);
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
            return await _categoriaService.AdicionarProdutoACategoria(categoriaId, produtoId);
        }

        public async Task<bool> RemoverProdutoDaCategoria(int categoriaId, int produtoId)
        {
            if (categoriaId <= 0)
            {
                throw new ArgumentException($"O categoriaId {categoriaId} não pode ser menor ou igual a zero");
            }
            return await _categoriaService.RemoverProdutoDaCategoria(categoriaId, produtoId);
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
            return await _categoriaService.Adicionar(dto);
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
            return await _categoriaService.Atualizar(dto);
        }

        public async Task<bool> Deletar(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("O id deve ser um número positivo.");
            }
            return await _categoriaService.Deletar(id);
        }

        public async Task<CategoriaDto> ObterPorId(int id)
        {
            if (id <= 0)
            {
                  throw new ArgumentException("Id não encontrado. O id deve ser um número positivo.");
            }
            return await _categoriaService.ObterPorId(id);
        }

        public async Task<List<CategoriaDto>> ObterTodos()
        {
            return await _categoriaService.ObterTodos();
        }
    }
}
    
