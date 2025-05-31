using Application.Dtos;
using Ecommerce.Domain.Entities;

namespace Application.Interfaces.Repository;

public interface IInformacoesEnvioRepository : IInterfaceBaseRepository<InformacoesEnvioDto, InformacoesEnvio>
{
    Task<InformacoesEnvioDto> ObterInformacoesEnvioPorId(int id);
    Task<IEnumerable<InformacoesEnvioDto>> ObterTodosInformacoesEnvio();
    Task<bool> AdicionarInformacoesEnvio(InformacoesEnvioDto informacoesEnvioDto);
    Task<bool> AtualizarInformacoesEnvio(InformacoesEnvioDto informacoesEnvioDto);
    Task<bool> DeletarInformacoesEnvio(int id);
}