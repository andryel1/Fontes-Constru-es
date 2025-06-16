using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record PagamentoDto(
    int Id,
    double Valor,
    string TipoPagamento,
    string Status,
    DateTime DataPagamento,
    Parcelamento Parcelamento,
    int ParcelamentoId,
    List<Pedido> Pedidos
);