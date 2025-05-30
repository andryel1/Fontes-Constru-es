using Application.Dtos;
using Ecommerce.Domain.Entities;

namespace Application.Interfaces.Repository;

public interface IListaDesejoRepository : IInterfaceBaseRepository<ListaDesejoDto, ListaDesejo>
{

    Task<ListaDesejoDto> ObterListaDesejoPorUsuario(Guid usuarioId);
    Task<bool> VerificaSeProdutoJaEstaNaLista(Guid usuarioId, Guid produtoId);
    Task<bool> RemoverProdutoDaLista(Guid usuarioId, Guid produtoId);
}