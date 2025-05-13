using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Tag : Entitybase
    {
        public string nome { get; set; }
        public Produto produto { get; set; }
        public int ProdutoId { get; set; }

    }
}   