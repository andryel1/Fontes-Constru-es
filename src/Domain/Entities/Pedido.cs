namespace Ecommerce.Domain.Entities
{
    public class Pedido : Entitybase
    {
        public DateTime DataPedido { get; set; }
        public required string Status { get; set; }
        public double ValorTotal { get; set; }
        public required List<Carrinho> Itens { get; set; } 
        public required List<Cliente> Clientes { get; set; }
        public DateTime? DataEnvio { get; set; }
        public DateTime? DataEntrega { get; set; }
    }
}