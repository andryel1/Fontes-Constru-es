using Application.Interfaces.Service;
using Application.Dtos; 

namespace Application.Service
{
    public class AdministradorService(IAdministradorService administradorService) : IAdministradorService
    {
        private readonly IAdministradorService _administradorService = administradorService;


        public async Task<AdministradorDto> Adicionar(AdministradorDto dto)
        {
            return await _administradorService.Adicionar(dto);
        }

        public async Task<AdministradorDto> Atualizar(AdministradorDto dto)
        {
            return await _administradorService.Atualizar(dto);
        }

        public async Task<bool> Deletar(int id)
        {
            return await _administradorService.Deletar(id);
        }

        public async Task<AdministradorDto> ObterPorId(int id)
        {
            return await _administradorService.ObterPorId(id);
        }

        public async Task<List<AdministradorDto>> ObterTodos()
        {
            return await _administradorService.ObterTodos();
        }
    }
}