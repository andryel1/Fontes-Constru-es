using Ecommerce.Domain.Entities;

namespace Application.Dtos;
public record CarrinhoDto(
    int Id,
    DateTime DataCriacao,
    List<ItemCarrinho> Itens,
    double PrecoTotal,
    int ClienteId,
    int PedidoId
); 