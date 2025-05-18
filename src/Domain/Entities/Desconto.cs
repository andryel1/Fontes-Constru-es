namespace Ecommerce.Domain.Entities
{
    public class Desconto : Entitybase
    {
        public required double Valor { get; set; }
        public required DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public required Produto Produto { get; set; } 
         public bool Ativo { get; set; }
        public int ProdutoId { get; set; }
    }
}