namespace Ecommerce.Domain.Entities
{
    public class InformacoesEnvio : Entitybase
    {
        public string Endereço { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Telefone { get; set; }
        public string NomeDestinatario { get; set; }
        public string SobrenomeDestinatario { get; set; }
        public string CpfDestinatario { get; set; }
        public string EmailDestinatario { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public DateTime DatetimeEnvio { get; set; }
        public DateTime DataDeEnvioPrevista { get; set; }
    }
}