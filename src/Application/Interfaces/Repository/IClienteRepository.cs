using Ecommerce.Domain.Entities;
using Application.Dtos; 


namespace Application.Interfaces.Repository
{
    public interface IClienteRepository : IInterfaceBaseRepository<ClienteDto, Cliente>
    {
        
    }
}