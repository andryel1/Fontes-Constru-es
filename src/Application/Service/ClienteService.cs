using Application.Interfaces.Services;

namespace application.service
{
    public class CarrinhoService : ICarrinhoService
    {
        private readonly ICarrinhoService _carrinhoService;

        public CarrinhoService(ICarrinhoService carrinhoService)
        {
            _carrinhoService = carrinhoService;
        }
    }
}
