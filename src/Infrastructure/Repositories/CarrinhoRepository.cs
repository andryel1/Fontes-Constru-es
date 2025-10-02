using Application.Dtos;
using Application.Interfaces.Repository;
using Ecommerce.Domain.Entities;


namespace Infrastructure.Repositories;

public class CarrinhoRepository(Context context): ICarrinhoRepository
{
    private readonly Context _context = context;
    public async Task<CarrinhoDto> Adicionar(CarrinhoDto entity)
    {
        var carrinhoEntity = new Carrinho
        {
            Id = entity.Id,
            DataCriacao = entity.DataCriacao,
            Itens = entity.Itens, 
            PrecoTotal = entity.PrecoTotal,
            PedidoId = entity.PedidoId,
            ClienteId = entity.ClienteId
        };
        await _context.Carrinhos.AddAsync(carrinhoEntity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public Task<bool> AdicionarProdutoAoCarrinho(int usuarioId, int produtoId, int quantidade)
    {
        throw new NotImplementedException();
    }

    public Task<CarrinhoDto> Atualizar(CarrinhoDto entity)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Deletar(int id)
    {
        var carrinho = await _context.Carrinhos.FindAsync(id);
          if (carrinho == null)
            return false;
            
        _context.Carrinhos.Remove(carrinho);
        await _context.SaveChangesAsync();
        return true;
        
    }

    public Task<bool> FinalizarCompra(int usuarioId, InformacoesEnvioDto informacoesEnvio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> LimparCarrinho(int usuarioId)
    {
        throw new NotImplementedException();
    }

    public Task<CarrinhoDto> ObterCarrinhoPorUsuarioId(int usuarioId)
    {
        throw new NotImplementedException();
    }

    public Task<CarrinhoDto> ObterPorId(int id)
    {
        var produto = _context.Carrinhos.Find(id);
        if (produto == null) return null!;
        return Task.FromResult(new CarrinhoDto(
            produto.Id,
            produto.DataCriacao,
            produto.Itens.ToList() ?? [],
            produto.PrecoTotal,
            produto.ClienteId,
            produto.PedidoId
        ));
    }

    public Task<List<CarrinhoDto>> ObterTodos()
    {
        throw new NotImplementedException();
    }
}