namespace Ecommerce.Domain.Entities
{
    public class Pedido : Entitybase
    {
        public DateTime DataPedido { get; set; }
        public string Status { get; set; }
        public double ValorTotal { get; set; }
        public ICollection<Carrinho> Itens { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
        public DateTime? DataEnvio { get; set; }
        public DateTime? DataEntrega { get; set; }
        public ICollection<Pagamento> Pagamentos { get; set; }
        public ICollection<InformacoesEnvio> InformacoesEnvio { get; set; }
    }
}