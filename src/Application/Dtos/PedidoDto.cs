using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record PedidoDto(
    int Id,
    double Valor,
    required string TipoPagamento,
    required string Status,
    DateTime DataPagamento,
    required int ParcelamentoId,
    required List<Pedido> Pedidos
);