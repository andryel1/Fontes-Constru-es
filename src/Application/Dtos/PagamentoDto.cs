using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public class PagamentoDto
{
      public double Valor { get; set; }
        public required string TipoPagamento { get; set; }
        public required string Status { get; set; }
        public DateTime DataPagamento { get; set; }
        public required Parcelamento Parcelamento { get; set; }
        public required int ParcelamentoId { get; set; }
        public required List<Pedido> Pedidos { get; set; }
}