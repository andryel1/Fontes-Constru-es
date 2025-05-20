using Application.Dtos;
using Ecommerce.Domain.Entities;

namespace Application.Interfaces.Repository;
public interface IInformacoesEnvioRepository : IInterfaceBaseRepository<InformacoesEnvioDto, InformacoesEnvio>
{
    Task<InformacoesEnvioDto> ObterInformacoesEnvioPorId(int id);
    Task<List<InformacoesEnvioDto>> ObterTodasInformacoesEnvio();
}