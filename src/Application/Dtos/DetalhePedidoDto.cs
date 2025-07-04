using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record DetalhePedidoDto(
        string? NomeProduto,
        int Quantidade,
        double Preco,
        double SubTotal,
        Pedido Pedido,
        int PedidoId
);
