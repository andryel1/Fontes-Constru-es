using Application.Dtos;
using Application.Interfaces.Repository;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Repositories;

public class ItemCarrinhoRepository(Context context) : IItemCarrinhoRepository
{
    private readonly Context _context = context;
    public async Task<ItemCarrinhoDto> Adicionar(ItemCarrinhoDto entity)
    {
        var itemCarrinho = new ItemCarrinho
        {
            ProdutoId = entity.ProdutoId,
            Quantidade = entity.Quantidade,
            CarrinhoId = entity.CarrinhoId
            
        };
        _context.Add(itemCarrinho);
        await _context.SaveChangesAsync();
        return entity;
    }

    public Task<ItemCarrinhoDto> Atualizar(ItemCarrinhoDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Deletar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ItemCarrinhoDto> ObterItemCarrinhoPorIdProduto(int idProduto)
    {
        throw new NotImplementedException();
    }

    public Task<ItemCarrinhoDto> ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ItemCarrinhoDto>> ObterTodos()
    {
        throw new NotImplementedException();
    }
}