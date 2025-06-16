using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service;

    public class ClienteService(IClienteService clienteService) : IClienteService
    {
        private readonly IClienteService _clienteService = clienteService;

        public async Task<ClienteDto> Adicionar(ClienteDto dto)
        {
            return await _clienteService.Adicionar(dto);
        }

        public async Task<ClienteDto> Atualizar(ClienteDto dto)
        {
            return await _clienteService.Atualizar(dto);
        }

        public async Task<bool> Deletar(int id)
        {
            return await _clienteService.Deletar(id);
        }

        public async Task<ClienteDto> ObterPorId(int id)
        {
            return await _clienteService.ObterPorId(id);
        }

        public async Task<List<ClienteDto>> ObterTodos()
        {
            return await _clienteService.ObterTodos();
        }
    }
    
