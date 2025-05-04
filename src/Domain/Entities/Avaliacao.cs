using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Avaliacao : Entitybase
    {
        public int Nota { get; set; }
        public string Comentario { get; set; }
        public DateTime Data { get; set; }
        public Cliente cliente { get; set; }
        public Produto Produto { get; set; }
        
    }
}