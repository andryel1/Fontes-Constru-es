namespace Ecommerce.Domain.Entities
{
    public class Categoria : Entitybase
    {
        public string? Nome;
        public ICollection<Produto> Produtos { get; set; } = [];
    }
}