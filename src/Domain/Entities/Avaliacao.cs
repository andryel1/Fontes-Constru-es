namespace Ecommerce.Domain.Entities
{
    public class Avaliacao : Entitybase
    {
        public int Nota { get; set; }
        public string? Comentario { get; set; }
        public DateTime Data { get; set; }
        public Cliente? Cliente { get; set; }
        public int ClienteId { get; set; }
        public Produto? Produto { get; set; }
        public int ProdutoId { get; set; }
    }
}