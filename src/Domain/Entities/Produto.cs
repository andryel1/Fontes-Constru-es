

namespace Ecommerce.Domain.Entities
{
    public class Produto : Entitybase
    {
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public required string Estoque { get; set; }
        public required string Preco { get; set; }
        public required ICollection<Imagem> Imagens { get; set; }
        public required ICollection<Avaliacao> Avaliacoes { get; set; }
        public required ICollection<ItemCarrinho> ItensCarrinho { get; set; }
        public required ICollection<Pedido> Pedidos { get; set; }
        public required ICollection<ListaDesejo> ListaDesejos { get; set; }
        public required ICollection<Categoria> Categorias { get; set; }
        public required ICollection<Tag> Tags { get; set; }
    }
}