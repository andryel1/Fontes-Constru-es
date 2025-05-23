using Application.Interfaces.Services;

namespace Application.Service;

public class InformacoesEnvioService : IInformacoesEnvioService
{
    private readonly IInformacoesEnvioService _informacoesEnvioService;

    public InformacoesEnvioService(IInformacoesEnvioService informacoesEnvioService)
    {
        _informacoesEnvioService = informacoesEnvioService;
    }
}
