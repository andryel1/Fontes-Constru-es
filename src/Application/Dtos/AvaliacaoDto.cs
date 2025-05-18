using  Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Dtos;

    public class AvaliacaoDto{
        public int Nota { get; set; }
        public required string Comentario { get; set; }
        public DateTime Data { get; set; }
    }
