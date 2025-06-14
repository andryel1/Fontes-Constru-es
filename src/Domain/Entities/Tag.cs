namespace Ecommerce.Domain.Entities
{
    public class Tag : Entitybase
    {
        public string Nome { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
    }
}   