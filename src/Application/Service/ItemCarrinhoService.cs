
using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service;

public class ItemCarrinhoService(IItemCarrinhoService itemCarrinhoService) : IItemCarrinhoService
{
    private readonly IItemCarrinhoService _itemCarrinhoService = itemCarrinhoService;

    

    public async Task<ItemCarrinhoDto> Adicionar(ItemCarrinhoDto dto)
    {
        if (dto.Produto == null)
        {
            throw new ArgumentException("Produto deve ser adicionado.");
        }
        return await _itemCarrinhoService.Adicionar(dto);
    }

    public async Task<ItemCarrinhoDto> Atualizar(ItemCarrinhoDto dto)
    {
    if (dto.ProdutoId <= 0)
    {
        throw new ArgumentException("ProdutoId deve ser maior que 0.");
    }
    return await _itemCarrinhoService.Atualizar(dto);
    }

    public async Task<bool> Deletar(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("O id só pode ser maior que 0.");
        }
        return await _itemCarrinhoService.Deletar(id);
    }

    public async Task<ItemCarrinhoDto> ObterPorId(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("O id só pode ser maior que 0.");
        }
        return await _itemCarrinhoService.ObterPorId(id);
    }

    public async Task<List<ItemCarrinhoDto>> ObterTodos()
    {
        return await _itemCarrinhoService.ObterTodos();
    }

   public async Task<ItemCarrinhoDto> ObterItemCarrinhoPorIdProduto(int idProduto)
{
    if (idProduto <= 0)
    {
        throw new ArgumentException("O idProduto deve ser maior que 0.");
    }
    return await _itemCarrinhoService.ObterItemCarrinhoPorIdProduto(idProduto);
}
}