namespace Ecommerce.Domain.Entities
{
    public class ListaDesejo : Entitybase
    {
        public DateTime DataAdicionada { get; set; }
        public ICollection<Produto> Produtos { get; set; } = [];
        public Cliente? Clientes { get; set; } 
        public int ClienteId { get; set; }
    }
}