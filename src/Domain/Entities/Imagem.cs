namespace Ecommerce.Domain.Entities
{
    public class Imagem : Entitybase
    {
        public Uri Url { get; set; }
        public string Descricao { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
    }
}