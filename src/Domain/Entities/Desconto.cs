namespace Ecommerce.Domain.Entities
{
    public class Desconto : Entitybase
    {
        public double Valor { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Ativo { get; set; }
        public int ProdutoId { get; set; }
        public ICollection<Produto> Produtos { get; set; } = [];
    }
}