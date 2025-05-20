using Application.Dtos;

namespace Application.Interfaces.Repository;

public interface ICategoriaRepository
{
    Task<CategoriaDto> AdicionarCategoria(CategoriaDto categoria);
    Task<CategoriaDto> AtualizarCategoria(CategoriaDto categoria);
    Task<bool> DeletarCategoria(int id);
    Task<CategoriaDto> ObterCategoriaPorId(int id);
    Task<List<CategoriaDto>> ObterTodasCategorias();
}