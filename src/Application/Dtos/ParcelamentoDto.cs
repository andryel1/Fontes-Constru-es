using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public class ParcelamentoDto
{
    public required double Valor { get; set; }
        public required int QuantidadeParcelas { get; set; }
        public required double Juros { get; set; }
        public required double ValorParcela { get; set; }
        public required DateTime DataVencimento { get; set; }
        public required Pagamento Pagamentos { get; set; }
        public required int PagamentoId { get; set; }
}