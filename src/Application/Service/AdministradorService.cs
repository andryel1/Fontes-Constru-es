using Application.Interfaces.Service;

namespace Application.Service
{
    public class AdministradorService(IAdministradorService administradorService)
    {
        private readonly IAdministradorService _administradorService = administradorService;
    }
}