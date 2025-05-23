using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service;

public class InformacoesEnvioService : IInformacoesEnvioService
{
    private readonly IInformacoesEnvioService _informacoesEnvioService;

    public InformacoesEnvioService(IInformacoesEnvioService informacoesEnvioService)
    {
        _informacoesEnvioService = informacoesEnvioService;
    }

    public async Task<InformacoesEnvioDto> ObterInformacoesEnvioPorId(Guid id)
    {
        return await _informacoesEnvioService.ObterInformacoesEnvioPorId(id);
    }

    public async Task<IEnumerable<InformacoesEnvioDto>> ObterTodosInformacoesEnvio()
    {
        return await _informacoesEnvioService.ObterTodosInformacoesEnvio();
    }

    public async Task<bool> AdicionarInformacoesEnvio(InformacoesEnvioDto dto)
    {
        return await _informacoesEnvioService.AdicionarInformacoesEnvio(dto);
    }

    public async Task<bool> AtualizarInformacoesEnvio(InformacoesEnvioDto dto)
    {
        return await _informacoesEnvioService.AtualizarInformacoesEnvio(dto);
    }

    public async Task<bool> DeletarInformacoesEnvio(Guid id)
    {
        return await _informacoesEnvioService.DeletarInformacoesEnvio(id);
    }

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
