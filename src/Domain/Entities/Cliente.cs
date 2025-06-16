namespace Ecommerce.Domain.Entities
{
    public class Cliente : Entitybase
    {
        public string? Nome { get; set; }
        public int Cpf { get; set; }
        public string? Password { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Usuario? Usuarios { get; set; }

        ICollection<ListaDesejo> ListaDesejos { get; set; } = [];
    }
}