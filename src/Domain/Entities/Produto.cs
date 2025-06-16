namespace Ecommerce.Domain.Entities
{
    public class Produto : Entitybase
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Estoque { get; set; }
        public decimal Preco { get; set; }
        public ICollection<Imagem> Imagens { get; set; } = [];
        public ICollection<Avaliacao> Avaliacoes { get; set; } = [];
        public ICollection<ItemCarrinho> ItensCarrinho { get; set; } = [];
        public ICollection<Pedido> Pedidos { get; set; } = [];
        public ICollection<ListaDesejo> ListaDesejos { get; set; } = [];
        public ICollection<Categoria> Categorias { get; set; } = [];
        public ICollection<Tag> Tags { get; set; } = [];
    }
}