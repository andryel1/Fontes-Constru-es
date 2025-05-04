using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Produto : Entitybase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Estoque { get; set; }
        public string Preco { get; set; }
       public collection<Imagem> Imagens { get; set; }
        public collection<Avaliacao> Avaliacoes { get; set; }
        public collection<ItemCarrinho> ItensCarrinho { get; set; }
        public collection<Pedido> Pedidos { get; set; }
        public collection<ListaDesejo> ListaDesejos { get; set; }
        public collection<Categoria> categorias { get; set; }
        public collection<Tag> Tags { get; set; }

    }
}