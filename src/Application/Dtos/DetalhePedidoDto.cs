using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public class DetalhePedidoDto
{
        public string? NomeProduto { get; set; }
        public  int Quantidade { get; set; }
        public double Preco { get; set; }
        public double SubTotal { get; set; }
        public int PedidoId { get; set; }
}