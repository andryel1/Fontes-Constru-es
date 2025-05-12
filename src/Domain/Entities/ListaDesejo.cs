using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ListaDesejo : Entitybase
    {
        public DateTime DataAdicionada { get; set; }
        public List<Produto> Produtos { get; set; }
        public List<Cliente> Clientes { get; set; } 
    }
}