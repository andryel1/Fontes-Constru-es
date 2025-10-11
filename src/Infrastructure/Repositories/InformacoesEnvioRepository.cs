using Application.Interfaces.Repository;
using Application.Dtos;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Repositories;

public class InformacoesEnvioRepository(Context context) : IInformacoesEnvioRepository
{
    private readonly Context _context = context;
    public async Task<InformacoesEnvioDto> Adicionar(InformacoesEnvioDto entity)
    {
        var informacoesEnvio = new InformacoesEnvio
        {

            
            Cidade = entity.Cidade,
            Estado = entity.Estado,
            Cep = entity.Cep,
    
        };
        _context.Add(informacoesEnvio);
        await _context.SaveChangesAsync();
        return entity;
    }

    public Task<InformacoesEnvioDto> Atualizar(InformacoesEnvioDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Deletar(int id)
    {
        throw new NotImplementedException();
    }
    public Task<InformacoesEnvioDto> ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<InformacoesEnvioDto>> ObterTodos()
    {
        throw new NotImplementedException();
    }
}