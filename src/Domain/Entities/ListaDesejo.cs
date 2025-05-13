using Ecommerce.Domain.Entities;

namespace Domain.Entities
{
    public class ListaDesejo : Entitybase
    {
        public DateTime DataAdicionada { get; set; }
        public required List<Produto> Produtos { get; set; }
        public required Cliente Clientes { get; set; } 
    }
}