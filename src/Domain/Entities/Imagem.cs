using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Uri;

namespace Domain.Entities
{
    public async Task class Imagem : Entitybase
    {
        public Uri Url { get; set; }
        public string Descricao { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        
    }
}