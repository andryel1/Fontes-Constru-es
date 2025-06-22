namespace Ecommerce.Domain.Entities
{
    public class DetalhePedido : Entitybase
    {
        public string? NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public decimal SubTotal { get; set; }
        public Pedido? Pedido { get; set; }
        public int PedidoId { get; set; }
    }
}
