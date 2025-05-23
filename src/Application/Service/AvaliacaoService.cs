using Application.Interfaces.Services;

namespace Application.Service
{
    public class AvaliacaoService : IAvaliacaoService
    {
        private readonly IAvaliacaoService _avaliacaoService;

        public AvaliacaoService(IAvaliacaoService avaliacaoService)
        {
            _avaliacaoService = avaliacaoService;
        }
    }
}
