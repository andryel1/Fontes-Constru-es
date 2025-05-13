using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Categoria : Entitybase
    {
        public string nome;
        public List<Produto> Produtos { get; set; } 
    }
}