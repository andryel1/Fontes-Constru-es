using Application.Interfaces.Service;

namespace Application.Service;

    public class ClienteService(IClienteService clienteService) : IClienteService
    {
        private readonly IClienteService _clienteService = clienteService;
    }
    
