namespace Ecommerce.Domain.Entities
{
    public class Categoria : Entitybase
    {
        public required string Nome;
        public required ICollection<Produto> Produtos { get; set; } 
    }
}