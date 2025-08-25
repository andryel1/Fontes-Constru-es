using Application.Dtos;
using Ecommerce.Domain.Entities;

namespace Application.Interfaces.Repository;

public interface IDescontoRepository : IInterfaceBaseRepository<DescontoDto, Desconto>
{
    Task<IEnumerable<DescontoDto>> ObterDescontosAtivos();
    Task<IEnumerable<DescontoDto>> ObterDescontosInativos();
    Task<IEnumerable<DescontoDto>> ObterDescontosExpirados();
    
}