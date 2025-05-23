using Application.Interfaces.Services;

namespace aapplication.Interfaces.Services;

    public class CarrinhoService : ICarrinhoService
    {
        private readonly ICarrinhoService _carrinhoService;

        public CarrinhoService(ICarrinhoService carrinhoService)
        {
            _carrinhoService = carrinhoService;
        }
    }
