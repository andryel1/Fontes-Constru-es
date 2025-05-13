using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Carrinho : Entitybase
    {
        public DateTime DataCriacao { get; set; }
        public List<ItemCarrinho> Itens { get; set; } 
        public double PrecoTotal { get; set; }
        public Cliente cliente { get; set; } 
        public int ClienteId { get; set; }
        public Pedido Pedido { get; set; }
        public int PedidoId { get; set; }
    }
}