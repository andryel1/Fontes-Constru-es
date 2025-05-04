namespace Documentos.PROJETOPESSOAL.Fontes_Constru_es.Domain.Entities
{
    class Usuario : Entitybase
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        
        public Cliente Cliente { get; set; }
        public Administrador Administrador { get; set; }
    }
}
