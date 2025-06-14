using Ecommerce.Domain.Entities;

namespace Application.Dtos;
public record CarrinhoDto(
    DateTime DataCriacao,
    required List<ItemCarrinho> Itens,
    double PrecoTotal,
    int ClienteId,
    int PedidoId
); 