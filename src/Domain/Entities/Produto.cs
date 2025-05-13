using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Produto : Entitybase
    {
        public string nome { get; set; }
        public string descricao { get; set; }
        public string estoque { get; set; }
        public string preco { get; set; }
       public collection<Imagem> imagens { get; set; }
        public collection<Avaliacao> avaliacoes { get; set; }
        public collection<ItemCarrinho> itensCarrinho { get; set; }
        public collection<Pedido> pedidos { get; set; }
        public collection<ListaDesejo> listaDesejos { get; set; }
        public collection<Categoria> categorias { get; set; }
        public collection<Tag> tags { get; set; }

    }
}