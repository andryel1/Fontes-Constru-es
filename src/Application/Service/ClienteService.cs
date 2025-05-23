using Application.Interfaces.Service;

namespace Application.Service;

    public class ClienteService(IClienteService clienteService)
    {
        private readonly IClienteService _clienteService = clienteService;
    }
    
