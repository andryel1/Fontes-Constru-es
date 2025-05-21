using Application.Dtos;
using Ecommerce.Domain.Entities;

namespace Application.Interfaces.Repository;

public interface ICarrinhoRepository : IInterfaceBaseRepository<CarrinhoDto, Carrinho>
{
    Task<CarrinhoDto> ObterCarrinhoPorUsuarioId(int usuarioId);
    Task<bool> AdicionarProdutoAoCarrinho(int usuarioId, int produtoId, int quantidade);
    Task<bool> LimparCarrinho(int usuarioId);
    Task<bool> FinalizarCompra(int usuarioId, InformacoesEnvioDto informacoesEnvio);
}