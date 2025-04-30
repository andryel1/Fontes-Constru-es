namespace Andryel.Documentos.PROJETOPESSOAL.Fontes_Constru_es.Domain.Entities
{
    public class Administrador : entity
    {
        public string Nome { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}