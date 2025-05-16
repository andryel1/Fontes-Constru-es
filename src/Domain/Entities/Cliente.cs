namespace Ecommerce.Domain.Entities
{
    public class Cliente : Entitybase
    {
        public required string Nome { get; set; }
        public required int Cpf { get; set; }
        public required string Password { get; set; }
        public required string Telefone { get; set; }
        public required string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Usuario? Usuarios { get; set; }
    
    }
    
}