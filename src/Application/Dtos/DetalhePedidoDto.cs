using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public class DetalhePedidoDto
{
        public required string NomeProduto { get; set; }
        public required int Quantidade { get; set; }
        public required double Preco { get; set; }
        public double SubTotal { get; set; }
        public int PedidoId { get; set; }
}