namespace Ecommerce.Domain.Entities
{
    public class Parcelamento : Entitybase
    {
        public double Valor { get; set; }
        public int QuantidadeParcelas { get; set; }
        public double Juros { get; set; }
        public double ValorParcela { get; set; }
        public DateTime DataVencimento { get; set; }
        public Pagamento? Pagamentos { get; set; }
        public int PagamentoId { get; set; }
    }
}