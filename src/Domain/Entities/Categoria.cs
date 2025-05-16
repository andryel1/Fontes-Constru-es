namespace Ecommerce.Domain.Entities
{
    public class Categoria : Entitybase
    {
        public required string Nome;
        public required List<Produto> Produtos { get; set; } 
    }
}