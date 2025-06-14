namespace Ecommerce.Domain.Entities;
    public class Carrinho : Entitybase
    {
        public DateTime DataCriacao { get; set; } 
        public ICollection<ItemCarrinho> Itens { get; set; } = [];
        public double PrecoTotal { get; set; }
        public Cliente Cliente { get; set; } = null!;
        public int ClienteId { get; set; }
        public Pedido Pedido { get; set; } 
        public int PedidoId { get; set; }
    }