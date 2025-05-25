using Application.Interfaces.Service;

namespace Application.Service
{
    public class AdministradorService(IAdministradorService administradorService) : IAdministradorService
    {
        private readonly IAdministradorService _administradorService = administradorService;
    }
}