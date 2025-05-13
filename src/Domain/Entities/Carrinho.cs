namespace Ecommerce.Domain.Entities;
    public class Carrinho : Entitybase
    {
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public required List<ItemCarrinho> Itens { get; set; } 
        public double PrecoTotal { get; set; }
        public Cliente Cliente { get; set; } = null!;
        public int ClienteId { get; set; }
        public Pedido Pedido { get; set; } = null!;
        public int PedidoId { get; set; }
    }