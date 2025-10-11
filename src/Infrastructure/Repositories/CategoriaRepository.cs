using Application.Dtos;
using Application.Interfaces.Repository;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Repositories;
 public class CategoriaRepository(Context context) : ICategoriaRepository
{
    private readonly Context _context = context;

    public async Task<CategoriaDto> Adicionar(CategoriaDto entity)
    {
        var categoria = new Categoria
        {
            Nome = entity.Nome
        };

        _context.Add(categoria);
        await _context.SaveChangesAsync();
        return entity;
    }


    public Task<bool> AdicionarProdutoACategoria(int categoriaId, int produtoId)
    {
        throw new NotImplementedException();
    }

    public async Task<CategoriaDto> Atualizar(CategoriaDto entity)
    {
        var categoria = await _context.Categorias.FindAsync(entity);
        if (categoria == null)
            return null!;

        categoria.Nome = entity.Nome;

        _context.Update(categoria);
        await _context.SaveChangesAsync();
        return entity;
    }

    

    public async Task<bool> Deletar(int id)
    {
        var categoria = await _context.Categorias.FindAsync(id);
        if (categoria == null) return false;

        _context.Categorias.Remove(categoria);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<CategoriaDto>> ObterCategoriasPorNome(string nome)
    {
        throw new NotImplementedException();
    }

    public Task<List<CategoriaDto>> ObterCategoriasPorProdutoId(int produtoId)
    {
        throw new NotImplementedException();
    }

    public Task<CategoriaDto> ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoverProdutoDaCategoria(int categoriaId, int produtoId)
    {
        throw new NotImplementedException();
    }

    Task<List<CategoriaDto>> IInterfaceBaseRepository<CategoriaDto, Categoria>.ObterTodos()
    {
        throw new NotImplementedException();
    }
}