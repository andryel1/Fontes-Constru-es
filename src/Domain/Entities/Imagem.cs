
namespace Ecommerce.Domain.Entities
{
    public class Imagem : Entitybase
    {
        public required Uri Url { get; set; }
        public required string Descricao { get; set; }
        public required Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        
    }
}