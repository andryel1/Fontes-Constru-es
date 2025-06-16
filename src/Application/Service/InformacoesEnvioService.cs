using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service;

public class InformacoesEnvioService(IInformacoesEnvioService informacoesEnvioService) : IInformacoesEnvioService
{
    private readonly IInformacoesEnvioService _informacoesEnvioService = informacoesEnvioService;

    public async Task<InformacoesEnvioDto> Adicionar(InformacoesEnvioDto dto)
    {
        return await _informacoesEnvioService.Adicionar(dto);
    }

    public async Task<InformacoesEnvioDto> Atualizar(InformacoesEnvioDto dto)
    {
        return await _informacoesEnvioService.Atualizar(dto);
    }

    public async Task<bool> Deletar(int id)
    {
        return await _informacoesEnvioService.Deletar(id);
    }

    public async Task<InformacoesEnvioDto> ObterPorId(int id)
    {
        return await _informacoesEnvioService.ObterPorId(id);
    }

    public async Task<List<InformacoesEnvioDto>> ObterTodos()
    {
        return await _informacoesEnvioService.ObterTodos();
    }
}
