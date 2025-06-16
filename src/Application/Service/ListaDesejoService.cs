using Application.Dtos;
using Application.Interfaces.Repository;
using Application.Interfaces.Service;

namespace Application.Service;

public class ListaDesejoService(IListaDesejoRepository listaDesejoService) : IListaDesejoService
{
    private readonly IListaDesejoRepository _listaDesejoRepository = listaDesejoService;

    public async Task<ListaDesejoDto> ObterListaDesejoPorUsuario(Guid usuarioId)
    {
        if (usuarioId == Guid.Empty)
        {
            throw new ArgumentException("Parâmetro 'usuarioId' está vazio.");
        }
        return await _listaDesejoRepository.ObterListaDesejoPorUsuario(usuarioId);
    }
public async Task<bool> VerificaSeProdutoJaEstaNaLista(Guid usuarioId, Guid produtoId)
{
    if (usuarioId == Guid.Empty)
    {   
        throw new ArgumentException("Parâmetro 'usuarioId' está vazio.");
    }

    if (produtoId == Guid.Empty)
    {
        throw new ArgumentException("Parâmetro 'produtoId' está vazio.");
    }

    return await _listaDesejoRepository.VerificaSeProdutoJaEstaNaLista(usuarioId, produtoId);
}

    public async Task<ListaDesejoDto> Adicionar(ListaDesejoDto dto)
    {
        if (dto.DataAdicionada == default)
            // dto.DataAdicionada = DateTime.UtcNow;

        if (dto.Produtos == null )
        {
            throw new ArgumentException("Você deve adicionar um produto");        
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
            throw new ArgumentException("O Id tem que ser maior que 0.");
        }
        return await _listaDesejoRepository.Deletar(id);
    }

    public async Task<ListaDesejoDto> ObterPorId(int id)
    {
        return await _listaDesejoRepository.ObterPorId(id);
    }

    public async Task<List<ListaDesejoDto>> ObterTodos()
    {
        return await _listaDesejoRepository.ObterTodos();
    }
}

    