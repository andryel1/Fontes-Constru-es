using Application.Dtos;

namespace Application.Interfaces.Repository;

public interface IInterfaceBaseRepository<TDto, TEntity>
{
    Task<TDto> Adicionar(TDto entity);
    Task<TDto> Atualizar(TDto entity);
    Task<bool> Deletar(int id);
    Task<TDto> ObterPorId(int id);
    Task<List<TDto>> ObterTodos();
}