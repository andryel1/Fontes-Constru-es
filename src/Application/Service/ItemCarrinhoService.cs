using Application.Interfaces.Service;
using Application.Interfaces.Repository; 
using Application.Dtos;

namespace Application.Service;

public class ItemCarrinhoService : IItemCarrinhoService
{
    private readonly IItemCarrinhoRepository _repository;

    public ItemCarrinhoService(IItemCarrinhoRepository repository)
    {
        _repository = repository; 
    }

    public async Task<ItemCarrinhoDto> Adicionar(ItemCarrinhoDto dto)
    {
        if (dto.Produto == null)
        {
            throw new ArgumentException("Produto deve ser adicionado.");
        }

        return await _repository.Adicionar(dto); 
    }

    public async Task<ItemCarrinhoDto> Atualizar(ItemCarrinhoDto dto)
    {
        if (dto.ProdutoId <= 0)
        {
            throw new ArgumentException("ProdutoId deve ser maior que 0.");
        }

        return await _repository.Atualizar(dto); 
    }

    public async Task<bool> Deletar(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("O id só pode ser maior que 0.");
        }
        return await _repository.Deletar(id); 
    }

    public async Task<ItemCarrinhoDto> ObterPorId(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("O id só pode ser maior que 0.");
        }
        // Chamada para o repositório
        return await _repository.ObterPorId(id); 
    }

    public async Task<List<ItemCarrinhoDto>> ObterTodos()
    {
        // Chamada para o repositório
        return await _repository.ObterTodos();
    }

    public async Task<ItemCarrinhoDto> ObterItemCarrinhoPorIdProduto(int idProduto)
    {
        if (idProduto <= 0)
        {
            throw new ArgumentException("O idProduto deve ser maior que 0.");
        }
        // Chamada para o repositório
        return await _repository.ObterItemCarrinhoPorIdProduto(idProduto);
    }
}