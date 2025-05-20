using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public class ListaDesejoDto{
 public DateTime DataAdicionada { get; set; }
        public required List<Produto> Produtos { get; set; }
        public required Cliente Clientes { get; set; }
}