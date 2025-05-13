namespace Ecommerce.Domain.Entities
{
    public class Categoria : Entitybase
    {
        public required string Nome;
        public List<Produto> Produtos { get; set; } 
    }
}