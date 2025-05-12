using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ItemCarrinho : Entitybase
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; } 
        public Carrinho Carrinho { get; set; } 
        public int CarrinhoId { get; set; } 
        public int ProdutoId { get; set; } 
    }
}