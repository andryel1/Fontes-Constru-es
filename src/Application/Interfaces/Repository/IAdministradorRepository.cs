using Application.Dtos;
using Ecommerce.Domain.Entities;

namespace Application.Interfaces.Repository
{
    public interface IAdministradorRepository : IInterfaceBaseRepository<AdministradorDto, Administrador>
    {
    }
}
