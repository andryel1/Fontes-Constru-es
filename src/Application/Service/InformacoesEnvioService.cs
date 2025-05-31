using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service;

public class InformacoesEnvioService(IInformacoesEnvioService informacoesEnvioService) : IInformacoesEnvioService
{
    private readonly IInformacoesEnvioService _informacoesEnvioService = informacoesEnvioService;

    public async Task<InformacoesEnvioDto> ObterInformacoesEnvioPorId(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("O id deve ser maior que zero.");
        }
        return await _informacoesEnvioService.ObterInformacoesEnvioPorId(id);
    }

    public async Task<IEnumerable<InformacoesEnvioDto>> ObterTodosInformacoesEnvio()
    {
        return await _informacoesEnvioService.ObterTodosInformacoesEnvio();
    }
   
    public async Task<bool> AdicionarInformacoesEnvio(InformacoesEnvioDto dto)
    {
        if (dto == null)
        {
            throw new ArgumentNullException(nameof(dto), "O DTO de informações de envio não pode ser nulo.");
        }
        return await _informacoesEnvioService.AdicionarInformacoesEnvio(dto);
    }

    public async Task<bool> AtualizarInformacoesEnvio(InformacoesEnvioDto dto)
    {
        if (dto == null)
        {
            throw new ArgumentNullException(nameof(dto), "O DTO de informações de envio não pode ser nulo.");
        }
        return await _informacoesEnvioService.AtualizarInformacoesEnvio(dto);
    }

    public async Task<bool> DeletarInformacoesEnvio(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("O id deve ser maior que zero.");
        }
        return await _informacoesEnvioService.DeletarInformacoesEnvio(id);
    }

    public async Task<InformacoesEnvioDto> Adicionar(InformacoesEnvioDto dto)
    {
        if (dto == null)
        {
            throw new ArgumentNullException(nameof(dto), "O DTO de informações de envio não pode ser nulo.");
        }
        return await _informacoesEnvioService.Adicionar(dto);
    }

    public async Task<InformacoesEnvioDto> Atualizar(InformacoesEnvioDto dto)
    {
        if (dto == null)
        {
            throw new ArgumentNullException(nameof(dto), "O DTO de informações de envio não pode ser nulo.");
        }
        return await _informacoesEnvioService.Atualizar(dto);
    }

    public async Task<bool> Deletar(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("O id deve ser maior que zero.");
        }
        return await _informacoesEnvioService.Deletar(id);
    }

    public async Task<InformacoesEnvioDto> ObterPorId(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("O id deve ser maior que zero.");
        }
        return await _informacoesEnvioService.ObterPorId(id);
    }

    public async Task<List<InformacoesEnvioDto>> ObterTodos()
    {
        return await _informacoesEnvioService.ObterTodos();
    }
}
