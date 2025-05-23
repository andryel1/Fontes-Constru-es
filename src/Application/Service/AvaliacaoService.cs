using Application.Interfaces.Service;

namespace Application.Service
{
    public class AvaliacaoService(IAvaliacaoService avaliacaoService)
    {
        private readonly IAvaliacaoService _avaliacaoService = avaliacaoService;
    }
}
