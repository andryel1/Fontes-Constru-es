using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pedido : Entitybase
    {
        public DateTime DataPedido { get; set; }
        public string Status { get; set; }
        public double ValorTotal { get; set; }
        public List<carrinho> Itens { get; set; } 
        public List<Cliente> Clientes { get; set; }
        public string dataEnvio { get; set; }
        public string dataEntrega { get; set; }
    }
}