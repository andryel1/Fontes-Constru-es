using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record PagamentoDto(
    double Valor,
    required string TipoPagamento,
    required string Status,
    DateTime DataPagamento,
    required Parcelamento Parcelamento,
    required int ParcelamentoId,
    required List<Pedido> Pedidos
);