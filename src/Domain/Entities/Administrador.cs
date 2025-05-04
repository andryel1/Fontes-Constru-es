namespace Domain.Entities
{
    public class Administrador : Entitybase
    {
        public string Nome { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Usuario Usuarios { get; set; }
    }
}