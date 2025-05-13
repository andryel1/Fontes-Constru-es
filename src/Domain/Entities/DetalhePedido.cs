using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DetalhePedido : Entitybase
    {
        public string nomeProduto { get; set; }
        public int quantidade { get; set; }
        public double preco { get; set; }
        public double subTotal { get; set; }
        public Pedido Pedido { get; set; }
        public int PedidoId { get; set; }
    }
}