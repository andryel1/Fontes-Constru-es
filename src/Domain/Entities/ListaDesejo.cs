namespace Ecommerce.Domain.Entities
{
    public class ListaDesejo : Entitybase
    {
        public DateTime DataAdicionada { get; set; }
        public required ICollection<Produto> Produtos { get; set;}
        public required Cliente Clientes { get; set; } 
    }
}