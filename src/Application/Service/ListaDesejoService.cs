using Application.Dtos;
using Application.Interfaces.Repository;
using Application.Interfaces.Service;

namespace Application.Service;

public class ListaDesejoService(IListaDesejoRepository listaDesejoService) : IListaDesejoService
{
    private readonly IListaDesejoRepository _listaDesejoRepository = listaDesejoService;

    public async Task<ListaDesejoDto> ObterListaDesejoPorUsuario(Guid usuarioId)
    {
        return await _listaDesejoRepository.ObterListaDesejoPorUsuario(usuarioId);
    }

    public Task<bool> VerificaSeProdutoJaEstaNaLista(Guid usuarioId, Guid produtoId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoverProdutoDaLista(Guid usuarioId, Guid produtoId)
    {
        throw new NotImplementedException();
    }

    public async Task<ListaDesejoDto> Adicionar(ListaDesejoDto dto)
    {
        if (dto.DataAdicionada == default)
            dto.DataAdicionada = DateTime.UtcNow;

        if (dto.Produtos == null )
        {
            throw new KeyNotFoundException("Você deve adicionar um produto");        
        }

        return await _listaDesejoRepository.Adicionar(dto);
    }

    public Task<ListaDesejoDto> Atualizar(ListaDesejoDto dto)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Deletar(int id)
    {
        if (id <= 0)
        {
            throw new KeyNotFoundException("O Id tem que ser maior que 0.");
        }
        return await _listaDesejoRepository.Deletar(id);
    }

    public Task<ListaDesejoDto> ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ListaDesejoDto>> ObterTodos()
    {
        throw new NotImplementedException();
    }
}

    