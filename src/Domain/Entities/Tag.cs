namespace Ecommerce.Domain.Entities
{
    public class Tag : Entitybase
    {
        public required string Nome { get; set; }
        public required Produto Produto { get; set; }
        public int ProdutoId { get; set; }

    }
}   