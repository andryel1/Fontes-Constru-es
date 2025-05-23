using Application.Interfaces.Service;

namespace Application.Service
{
    public class DescontoService(IDescontoService descontoService)
    {
        private readonly IDescontoService _descontoService = descontoService;
    }
}
