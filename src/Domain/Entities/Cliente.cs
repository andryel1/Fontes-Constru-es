namespace Ecommerce.Domain.Entities
{
    public class Cliente : Entitybase
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Password { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Usuario? Usuario { get; set; }
        public int UsuarioId { get; set; }
        ICollection<ListaDesejo> ListaDesejos { get; set; } = [];
    }
}