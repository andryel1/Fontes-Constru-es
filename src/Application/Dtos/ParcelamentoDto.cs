using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record ParcelamentoDto(
    int Id,
    double Valor,
    int QuantidadeParcelas,
    double Juros,
    double ValorParcela,
    DateTime DataVencimento,
    Pagamento Pagamentos,
    int PagamentoId
);