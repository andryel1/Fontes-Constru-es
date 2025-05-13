using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Desconto : Entitybase
    {
        public double Valor { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Produto Produto { get; set; } 
        public int ProdutoId { get; set; }
    }
}