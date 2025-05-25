using Application.Dtos;
using Ecommerce.Domain.Entities;


namespace Application.Interfaces.Repository;

public interface IPagamentoRepository : IInterfaceBaseRepository<PagamentoDto, Pagamento>
{
    Task<PagamentoDto> ObterPagamentoPorPedidoId(int pedidoId);
    Task<bool> VerificarSePagamentoJaFoiRealizado(int pedidoId);
}