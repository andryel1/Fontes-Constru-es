namespace Ecommerce.Domain.Entities
{
    public class Desconto : Entitybase
    {
        public required double Valor { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public required Produto Produto { get; set; } 
        public int ProdutoId { get; set; }
    }
}