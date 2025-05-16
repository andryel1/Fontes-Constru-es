using Ecommerce.Domain.Entities;

namespace Application.Dtos;
public class CarrinhoDto
{
     public DateTime DataCriacao { get; set; } 
        public required List<ItemCarrinho> Itens { get; set; } 
        public double PrecoTotal { get; set; }
        public required Cliente Cliente { get; set; } 
        public int ClienteId { get; set; }
        public required Pedido Pedido { get; set; } 
        public int PedidoId { get; set; }
} 