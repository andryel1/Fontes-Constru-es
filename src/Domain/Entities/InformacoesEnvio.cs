namespace Ecommerce.Domain.Entities
{
    public class InformacoesEnvio : Entitybase
    {
        public required string Endereço { get; set; }
        public required string Cidade { get; set; }
        public required string Estado { get; set; }
        public required string Cep { get; set; }
        public required int Numero { get; set; }
        public required string Complemento { get; set; }
        public required string Telefone { get; set; }
        public required string NomeDestinatario { get; set; }
        public required string SobrenomeDestinatario { get; set; }
        public required string CpfDestinatario { get; set; }
        public required string EmailDestinatario { get; set; }
        public required Produto Produto { get; set; }
        public required int ProdutoId { get; set; }
        public required DateTime DatetimeEnvio { get; set; }
        public required DateTime DataDeEnvioPrevista { get; set; }
    }
}