using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record ParcelamentoDto(
    required double Valor,
    required int QuantidadeParcelas,
    required double Juros,
    required double ValorParcela,
    required DateTime DataVencimento,
    required Pagamento Pagamentos,
    required int PagamentoId
);