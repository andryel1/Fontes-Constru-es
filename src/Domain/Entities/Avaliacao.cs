namespace Ecommerce.Domain.Entities
{
    public class Avaliacao : Entitybase
    {
        public int Nota { get; set; }
        public required string Comentario { get; set; }
        public DateTime Data { get; set; }
        public required Cliente Cliente { get; set; }
        public required Produto Produto { get; set; }
        
    }
}