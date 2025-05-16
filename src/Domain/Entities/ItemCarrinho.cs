
namespace Ecommerce.Domain.Entities
{ 
    public class ItemCarrinho : Entitybase
    {
        public int Quantidade { get; set; }
        public required double Preco { get; set; }
        public required Produto Produto { get; set; } 
        public required Carrinho Carrinho { get; set; } 
        public int CarrinhoId { get; set; } 
        public int ProdutoId { get; set; } 
    }
}