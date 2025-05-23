
using Application.Interfaces.Service;
using Application.Dtos;

namespace Application.Service;

public class ItemCarrinhoService(IItemCarrinhoService itemCarrinhoService) : IItemCarrinhoService
{
    private readonly IItemCarrinhoService _itemCarrinhoService = itemCarrinhoService;

    public async Task<ItemCarrinhoDto> ObterItemCarrinhoPorId(Guid id)
    {
        return await _itemCarrinhoService.ObterItemCarrinhoPorId(id);
    }

    public async Task<ItemCarrinhoDto> ObterItemCarrinhoPorIdProduto(Guid idProduto)
    {
        return await _itemCarrinhoService.ObterItemCarrinhoPorIdProduto(idProduto);
    }

    public async Task<ItemCarrinhoDto> Adicionar(ItemCarrinhoDto dto)
    {
        return await _itemCarrinhoService.Adicionar(dto);
    }

    public async Task<ItemCarrinhoDto> Atualizar(ItemCarrinhoDto dto)
    {
        return await _itemCarrinhoService.Atualizar(dto);
    }

    public async Task<bool> Deletar(int id)
    {
        return await _itemCarrinhoService.Deletar(id);
    }

    public async Task<ItemCarrinhoDto> ObterPorId(int id)
    {
        return await _itemCarrinhoService.ObterPorId(id);
    }

    public async Task<List<ItemCarrinhoDto>> ObterTodos()
    {
        return await _itemCarrinhoService.ObterTodos();
    }
}