using Application.Interfaces.Services;

namespace Application.service;

public class PedidoService : IPedidoService
{
   private readonly IPedidoService _pedidoService;

        public PedidoService(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }
}
