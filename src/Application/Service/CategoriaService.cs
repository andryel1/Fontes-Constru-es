using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service
{
    public class CategoriaService(ICategoriaService categoriaService) : ICategoriaService
    {
        private readonly ICategoriaService _categoriaService = categoriaService;

        public Task<List<CategoriaDto>> ObterCategoriasPorNome(string nome)
        {
            return _categoriaService.ObterCategoriasPorNome(nome);
        }

        public Task<List<CategoriaDto>> ObterCategoriasPorProdutoId(int produtoId)
        {
            return _categoriaService.ObterCategoriasPorProdutoId(produtoId);
        }

        public Task<bool> AdicionarProdutoACategoria(int categoriaId, int produtoId)
        {
            return _categoriaService.AdicionarProdutoACategoria(categoriaId, produtoId);
        }

        public Task<bool> RemoverProdutoDaCategoria(int categoriaId, int produtoId)
        {
            return _categoriaService.RemoverProdutoDaCategoria(categoriaId, produtoId);
        }

        public Task<CategoriaDto> Adicionar(CategoriaDto dto)
        {
            return _categoriaService.Adicionar(dto);
        }

        public Task<CategoriaDto> Atualizar(CategoriaDto dto)
        {
            return _categoriaService.Atualizar(dto);
        }

        public Task<bool> Deletar(int id)
        {
            return _categoriaService.Deletar(id);
        }

        public Task<CategoriaDto> ObterPorId(int id)
        {
            return _categoriaService.ObterPorId(id);
        }

        public Task<List<CategoriaDto>> ObterTodos()
        {
            return _categoriaService.ObterTodos();
        }
    }
}
    
