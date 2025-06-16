namespace Ecommerce.Domain.Entities
{
    public class Pagamento : Entitybase
    {
        public double Valor { get; set; }
        public string? TipoPagamento { get; set; }
        public string? Status { get; set; }
        public DateTime DataPagamento { get; set; }
        public Parcelamento? Parcelamento { get; set; }
        public int ParcelamentoId { get; set; }
        public List<Pedido> Pedidos { get; set; } = [];
    }
}