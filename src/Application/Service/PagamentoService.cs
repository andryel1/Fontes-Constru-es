using Application.Interfaces.Services;

namespace Application.Service
{
    public class PagamentoService : IPagamentoService
    {
        private readonly IPagamentoService _pagamentoService;

        public PagamentoService(IPagamentoService pagamentoService)
        {
            _pagamentoService = pagamentoService;
        }
    }
}
